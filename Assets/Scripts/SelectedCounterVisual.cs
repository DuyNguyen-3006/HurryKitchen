using UnityEngine;

public class SelectedCounterVisual : MonoBehaviour
{
    [SerializeField] private ClearCounter clearCounter;
    [SerializeField] private GameObject visualGameObject;

    private void Start()
    {
        // Ẩn mặc định
        if (visualGameObject != null) visualGameObject.SetActive(false);

        // Đăng ký sự kiện sau khi Player.Instance đã có (Player.Instance set trong Awake)
        if (Player.Instance != null)
            Player.Instance.OnSelectedCounterChanged += Player_OnSelectedCounterChanged;
        else
            Debug.LogError("SelectedCounterVisual: Player.Instance is null. Ensure Player exists in scene.");
    }

    private void OnDestroy()
    {
        if (Player.Instance != null)
            Player.Instance.OnSelectedCounterChanged -= Player_OnSelectedCounterChanged;
    }

    private void Player_OnSelectedCounterChanged(object sender, Player.OnselectedCounterChangedEventArgs e)
    {
        if (e.selectedCounter == clearCounter)
            Show();
        else
            Hide();
    }

    private void Show() { if (visualGameObject != null) visualGameObject.SetActive(true); }
    private void Hide() { if (visualGameObject != null) visualGameObject.SetActive(false); }
}