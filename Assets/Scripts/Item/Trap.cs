using UnityEngine;

public class Trap : MonoBehaviour
{
    [SerializeField] private int damageAmount  =5; 
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            FindFirstObjectByType<PlayerHurtHandler>().PlayerHurt(damageAmount);
        }
    }
}
