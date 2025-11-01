using UnityEngine;

public class SelectedCounterVisual : MonoBehaviour
{
    [SerializeField] private BaseCounter baseCounter;
    [SerializeField] private GameObject[] visualGameObjectArray;

    private void Start()
    {
        // Ẩn mặc định
        //if (visualGameObjectArray != null) visualGameObjectArray.SetActive(false);

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
        if (e.selectedCounter == baseCounter)
            Show();
        else
            Hide();
    }

    private void Show()
    {
        foreach (GameObject visualGameObject in visualGameObjectArray)
        {
            visualGameObject.SetActive(true);
        }
    }
    private void Hide()
    {
        foreach (GameObject visualGameObject in visualGameObjectArray) { 

            visualGameObject.SetActive(false);
          }
    }
}