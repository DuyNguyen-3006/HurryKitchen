using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 7f; // Tốc độ di chuyển của nhân vật
    [SerializeField] private GameInput gameInput;   
    private bool isWalking = false;
    private void Update()
    {
       Vector2 inputVector = gameInput.GetMovementVectorNormalized();

        Vector3 moveDir = new Vector3(inputVector.x, 0f, inputVector.y);

        // B4: Di chuyển nhân vật
        transform.position += moveDir * moveSpeed * Time.deltaTime;

        isWalking = moveDir != Vector3.zero;

        float rotateSpeed = 10f;
        transform.forward = Vector3.Slerp(transform.forward, moveDir, Time.deltaTime * rotateSpeed);
        Debug.Log($"Input Vector: {inputVector}, Move Direction: {moveDir}, New Position: {transform.position}");
    }

    public bool IsWalking()
    {
        return isWalking;
    }
}
