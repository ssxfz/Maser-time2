using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 100f;

    public Transform playerBody;  // посилання на тіло персонажа (обертаємо по Y)
    public Transform playerCamera; // посилання на камеру (обертаємо по X)

    float xRotation = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;  // ховаємо курсор і блокування миші
    }

    void Update()
    {
        // Отримуємо рух миші по X та Y
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        // Обмежуємо обертання камери по вертикалі
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        // Обертаємо камеру по X (вверх-вниз)
        playerCamera.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        // Обертаємо тіло персонажа по Y (вліво-вправо)
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
