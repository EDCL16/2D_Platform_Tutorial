using UnityEngine;

public class FlipPlayerSprite : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private Rigidbody2D rb;
    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(rb.linearVelocityX > 0 )
        {
            spriteRenderer.flipX = false;
        }
        else if(rb.linearVelocityX < 0)
        {
            spriteRenderer.flipX = true;
        }
    }
}
