using UnityEngine;

public class EnemyHurtPlayer : MonoBehaviour
{
    private int damage =5;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<PlayerHurtHandler>().PlayerHurt(damage);
        }
    }

    public void SetEnemyDamage(int _damage)
    {
        damage = _damage;
    }
}
