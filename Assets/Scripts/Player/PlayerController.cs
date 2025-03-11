using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]private float moveSpeed = 5f;
    [SerializeField]private float jumpSpeed = 5f;
    private Rigidbody2D rb;
    private CheckGround checkGround;
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        checkGround = GetComponentInChildren<CheckGround>();
    }

    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        rb.linearVelocity = new Vector2(xInput *moveSpeed, rb.linearVelocity.y);

        if(Input.GetKeyDown(KeyCode.Space) && checkGround.isGrounded)
        {
            Jump();
        }


    }

    void Jump()
    {
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpSpeed);
    }
}
