using UnityEngine;

public class CheckGround : MonoBehaviour
{
    public bool isGrounded;
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Platform"))
        {
            isGrounded = true;
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Platform"))
        {
            isGrounded = false;
        }
    }
}
