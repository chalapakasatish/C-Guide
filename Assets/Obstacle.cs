using UnityEngine;

public class Obstacle : MonoBehaviour, IDamageable
{
    private int health = 10;

    public virtual void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Destroy(gameObject);
            // Game over logic
            Debug.Log(" ObstacleGame Over");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent(out Player player)) 
        {
            if (other.TryGetComponent(out IDamageable damageable))
            {
                damageable.TakeDamage(10);
            }
            else
            {
                TakeDamage(10);
            }
        }
    }
}
