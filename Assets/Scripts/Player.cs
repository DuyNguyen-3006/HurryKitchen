using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 7f; // Tốc độ di chuyển của nhân vật
    private bool isWalking = false;
    private void Update()
    {
        // B1: Tạo vector đầu vào (Input)
        Vector2 inputVector = new Vector2(0, 0);

        if (Input.GetKey(KeyCode.W))
            inputVector.y = +1; // Đi lên

        if (Input.GetKey(KeyCode.S))
            inputVector.y = -1; // Đi xuống

        if (Input.GetKey(KeyCode.A))
            inputVector.x = -1; // Sang trái

        if (Input.GetKey(KeyCode.D))
            inputVector.x = +1; // Sang phải

        // B2: Chuẩn hóa hướng di chuyển (để khi đi chéo không nhanh hơn)
        inputVector = inputVector.normalized;

        // B3: Tạo vector 3D từ vector 2D (x, y -> x, z trong không gian Unity)
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
