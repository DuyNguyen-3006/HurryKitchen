using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, IKitchenObjectParent
{

    public static Player Instance { get; private set; }
    [Header("Move")]
    [SerializeField] private float moveSpeed = 7f;
    [SerializeField] private float rotateSpeed = 10f;

    [Header("Capsule for collision check")]
    [SerializeField] private float capsuleHeight = 1.8f;
    [SerializeField] private float capsuleRadius = 0.35f;
    [SerializeField] private float skin = 0.02f;
    [SerializeField] private LayerMask obstacleMask = ~0;

    [Header("Frontal block settings")]
    [SerializeField] private float frontalBlockAngleDeg = 50f; // coi là “đụng thẳng mặt” nếu <= góc này

    [SerializeField] private GameInput gameInput;
    [SerializeField] private LayerMask countersLayerMask;
    [SerializeField] private Transform kitchenObjectHoldPoint;

    private bool isWalking;
    private BaseCounter selectedCounter;

    public event EventHandler<OnselectedCounterChangedEventArgs> OnSelectedCounterChanged;
    private KitchenObject kitchenObject;

    public class OnselectedCounterChangedEventArgs : EventArgs
    {
        public BaseCounter selectedCounter;
    }

    private void Awake()
    {
        if (Instance != null)
        {
            Debug.LogError("There is more than one Player instance");
        }
        Instance = this;
    }

    private void Start()
    {
        gameInput.OnInteractAction += GameInput_OnInteractAction;
        gameInput.OnInteractAlternateAction += GameInput_OnInteractAlternateAction;
    }

    private void GameInput_OnInteractAlternateAction(object sender, EventArgs e)
    {
        if (selectedCounter != null)
        {
            selectedCounter.InteractAlternate(this);
        }

    }

    private void GameInput_OnInteractAction(object sender, System.EventArgs e)
    {
        if(selectedCounter != null) {
            
                selectedCounter.Interact(this);
            } 
        
    }

    private void Update()
    {
        HandleMovement();

        HandleInteractions();
    }

    public bool IsWalking() => isWalking;
    private Vector3 lastInteractDir;
    private void HandleInteractions()
    {
        Vector2 input = gameInput.GetMovementVectorNormalized();
        Vector3 moveDir = new Vector3(input.x, 0f, input.y);
        if (moveDir != Vector3.zero) lastInteractDir = moveDir;

        float interactDistance = 2f;
        float interactRadius = 0.3f;

        // Bắn tia từ ngang ngực để tránh dính sàn/chân
        Vector3 origin = transform.position + Vector3.up * 1.0f;

        bool hitSomething = Physics.SphereCast(origin, interactRadius, lastInteractDir,
            out RaycastHit hitInfo, interactDistance, countersLayerMask, QueryTriggerInteraction.Collide);

        if (hitSomething && hitInfo.transform.TryGetComponent(out BaseCounter baseCounter))
            SetSelectedCounter(baseCounter);
        else
            SetSelectedCounter(null);

        // Debug
        Debug.DrawRay(origin, lastInteractDir.normalized * interactDistance, hitSomething ? Color.green : Color.red);
    }

    private void HandleMovement()
    {
        Vector2 input = gameInput.GetMovementVectorNormalized(); // x = A/D, y = W/S
        Vector3 moveDir = new Vector3(input.x, 0f, input.y);
        float inputMag = moveDir.magnitude;

        Vector3 movedThisFrame = Vector3.zero;

        if (inputMag > 0.0001f)
        {
            moveDir.Normalize();
            float maxDistance = moveSpeed * Time.deltaTime;

            // Xác định capsule theo vị trí hiện tại
            Vector3 center = transform.position;
            float half = Mathf.Max(0f, (capsuleHeight * 0.5f) - capsuleRadius);
            Vector3 p1 = center + Vector3.up * half;
            Vector3 p2 = center + Vector3.up * (half * 2);

            if (Physics.CapsuleCast(p1, p2, capsuleRadius, moveDir, out RaycastHit hit, maxDistance + skin, obstacleMask, QueryTriggerInteraction.Ignore))
            {
                // Đang bị chặn theo hướng moveDir
                float cosFrontal = Mathf.Cos(frontalBlockAngleDeg * Mathf.Deg2Rad);
                float againstNormal = Vector3.Dot(moveDir, -hit.normal); // >0 tức là đang hướng vào tường

                bool frontalBlocked = againstNormal >= cosFrontal;

                if (frontalBlocked)
                {
                    // Nếu chỉ bấm W/S thuần (|input.x| ~ 0) -> đứng yên.
                    // Nếu có A hoặc D (WA/WD) -> chỉ cho trượt theo trái/phải.
                    bool hasLateral = Mathf.Abs(input.x) > 0.1f && Mathf.Abs(moveDir.x) > 0f;

                    if (hasLateral)
                    {
                        // Hướng trượt lấy từ A/D, rồi chiếu lên mặt phẳng của tường
                        Vector3 lateralDir = new Vector3(Mathf.Sign(input.x), 0f, 0f); // trái/phải theo trục X thế giới
                        Vector3 slideDir = Vector3.ProjectOnPlane(lateralDir, hit.normal).normalized;

                        if (slideDir.sqrMagnitude > 0.0001f)
                        {
                            if (Physics.CapsuleCast(p1, p2, capsuleRadius, slideDir, out RaycastHit slideHit, maxDistance + skin, obstacleMask, QueryTriggerInteraction.Ignore))
                            {
                                float allowed = Mathf.Max(0f, slideHit.distance - skin);
                                if (allowed > 0f)
                                {
                                    movedThisFrame = slideDir * allowed;
                                    transform.position += movedThisFrame;
                                }
                            }
                            else
                            {
                                movedThisFrame = slideDir * maxDistance;
                                transform.position += movedThisFrame;
                            }
                        }
                        // nếu slideDir quá nhỏ -> coi như đứng yên
                    }
                    // không có A/D -> đứng yên (không cộng position)
                }
                else
                {
                    if (Mathf.Abs(moveDir.z) > 0f)
                    {
                        // Va chạm lướt/chéo: cho trượt theo tiếp tuyến bề mặt
                        Vector3 slideDir = Vector3.ProjectOnPlane(moveDir, hit.normal).normalized;

                        if (slideDir.sqrMagnitude > 0.0001f)
                        {
                            if (Physics.CapsuleCast(p1, p2, capsuleRadius, slideDir, out RaycastHit slideHit, maxDistance + skin, obstacleMask, QueryTriggerInteraction.Ignore))
                            {
                                float allowed = Mathf.Max(0f, slideHit.distance - skin);
                                if (allowed > 0f)
                                {
                                    movedThisFrame = slideDir * allowed;
                                    transform.position += movedThisFrame;
                                }
                            }
                            else
                            {
                                movedThisFrame = slideDir * maxDistance;
                                transform.position += movedThisFrame;
                            }
                        }
                    }
                }
            }
            else
            {
                // Không va chạm: đi bình thường
                movedThisFrame = moveDir * maxDistance;
                transform.position += movedThisFrame;
            }

            // Xoay theo hướng chuyển động thực tế (chỉ xoay khi có di chuyển)
            if (movedThisFrame.sqrMagnitude > 0f)
            {
                Vector3 faceDir = movedThisFrame.normalized;
                transform.forward = Vector3.Slerp(transform.forward, faceDir, Time.deltaTime * rotateSpeed);
            }
        }

        isWalking = inputMag > 0.0001f;

    }

    private void SetSelectedCounter(BaseCounter selectedCounter)
    {
                this.selectedCounter = selectedCounter;

        OnSelectedCounterChanged?.Invoke(this, new OnselectedCounterChangedEventArgs
        {
            selectedCounter = selectedCounter
        });
    }

    public Transform GetKitchenObjectFollowTransform()
    {
        return kitchenObjectHoldPoint;

    }
    public void SetKitchenObject(KitchenObject kitchenObject)
    {
        this.kitchenObject = kitchenObject;
    }
    public KitchenObject GetKitchenObject()
    {
        return kitchenObject;
    }
    public void ClearKitchenObject()
    {
        kitchenObject = null;

    }
    public bool HasKitchenObject()
    {
        return (kitchenObject != null);
    }
}
