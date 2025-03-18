using UnityEngine;

public class SlimeSquare : MonoBehaviour
{
    [SerializeField]int jumpSpeed;
    void OnCollisionEnter2D(Collision2D collision)
    {
        Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();
        rb.linearVelocityY += jumpSpeed;
    }
    // if(collision.gameObject.CompareTag("Player"))
    //     {
            
    //     }
}
