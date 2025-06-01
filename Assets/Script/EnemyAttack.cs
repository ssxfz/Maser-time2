using UnityEngine;
using UnityEngine.AI;

public class EnemyAttack : MonoBehaviour
{
    public Transform player;
    public int damage = 15;
    public float attackRange = 2f;  // дистанція, на якій ворог може атакувати
    public float attackCooldown = 1f; // затримка між атаками (1 секунда)

    private PlayerHealth playerHealth;
    private NavMeshAgent agent;
    private float lastAttackTime;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        playerHealth = player.GetComponent<PlayerHealth>();
        lastAttackTime = -attackCooldown;  // щоб можна було атакувати відразу
    }

    void Update()
    {
        if (player == null || playerHealth == null)
            return;

        agent.SetDestination(player.position);

        float distance = Vector3.Distance(transform.position, player.position);
        if (distance <= attackRange)
        {
            if (Time.time - lastAttackTime >= attackCooldown)
            {
                Attack();
                lastAttackTime = Time.time;
            }
        }
    }

    void Attack()
    {
        playerHealth.TakeDamage(damage);
        Debug.Log("Enemy attacked player for " + damage + " damage.");
    }
}
