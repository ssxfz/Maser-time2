using UnityEngine;

public class ShootProjectile : MonoBehaviour
{
    public GameObject projectilePrefab;   // Префаб пострілу
    public float shootForce = 700f;       // Сила пострілу
    public Transform shootPoint;          // Точка, з якої летить постріл (наприклад, біля камери або зброї)

    void Update()
    {
        if (Input.GetMouseButtonDown(0))  // Ліва кнопка миші
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // Створюємо копію префабу в позиції shootPoint і з його поворотом
        GameObject projectile = Instantiate(projectilePrefab, shootPoint.position, shootPoint.rotation);

        // Додаємо силу вперед по напрямку, куди дивиться shootPoint
        Rigidbody rb = projectile.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.AddForce(shootPoint.forward * shootForce);
        }
    }
}
