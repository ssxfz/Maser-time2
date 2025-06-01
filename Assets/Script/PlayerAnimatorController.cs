using UnityEngine;

public class PlayerAnimatorController : MonoBehaviour
{
    public Animator animator;
    public CharacterController controller;

    void Update()
    {
        // Отримуємо швидкість персонажа по горизонталі (без врахування гравітації)
        Vector3 horizontalVelocity = new Vector3(controller.velocity.x, 0, controller.velocity.z);
        float speed = horizontalVelocity.magnitude;

        // Передаємо швидкість в Animator
        animator.SetFloat("Speed", speed);
    }
}
