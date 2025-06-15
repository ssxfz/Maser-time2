using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision collision)
    {
        // Якщо пуля стикається з ворогом
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // Можна виконати будь-які дії, наприклад, знищити ворога
            Destroy(collision.gameObject);  // Знищуємо ворога
            Destroy(gameObject);  // Знищуємо пуля
        }
    }
}
