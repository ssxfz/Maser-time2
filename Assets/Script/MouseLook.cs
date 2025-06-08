using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float sensitivity = 2.0f; // Чутливість миші
    public float verticalLimit = 80.0f; // Обмеження кута по вертикалі (щоб не перевертатися)

    private float rotationX = 0.0f; // Поточний кут повороту по осі X

    void Start()
    {
        // Опціонально: приховати курсор і зафіксувати його в центрі
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        // Отримуємо рух миші по осях
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

        // Обчислюємо поворот по вертикалі (вгору-вниз)
        rotationX -= mouseY;
        rotationX = Mathf.Clamp(rotationX, -verticalLimit, verticalLimit); // Обмежуємо кут

        // Застосовуємо поворот до камери
        transform.localRotation = Quaternion.Euler(rotationX, 0, 0);

        // Поворот гравця (або камери) по горизонталі (вліво-вправо)
        transform.parent.Rotate(Vector3.up * mouseX); // Якщо камера прив’язана до гравця
        // Або: transform.Rotate(Vector3.up * mouseX); // Якщо камера незалежна
    }
}

// using UnityEngine;

// public class MouseLook : MonoBehaviour
// {
//     public float mouseSensitivity = 100f;

//     public Transform playerBody;    // обертаємо по Y (тіло гравця)
//     public Transform playerCamera;  // обертаємо по X (камера)

//     float xRotation = 0f;

//     void Start()
//     {
//         Cursor.lockState = CursorLockMode.Locked;  // ховаємо і блокуюємо курсор
//         Cursor.visible = false;                     // ховаємо курсор (додано)
//     }

//     void Update()
//     {
//         float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
//         float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

//         xRotation -= mouseY;
//         xRotation = Mathf.Clamp(xRotation, -90f, 90f);

//         playerCamera.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
//         playerBody.Rotate(Vector3.up * mouseX);
//     }
// }
