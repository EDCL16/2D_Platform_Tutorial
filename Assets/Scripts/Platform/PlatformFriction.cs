using UnityEngine;

public class PlatformFriction : MonoBehaviour
{
    private Vector2 speedOffset;
    [SerializeField]MovingPlatform movingPlatform; 

    void Update()
    {
        speedOffset = movingPlatform.GetCurrentSpeed();
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.transform.SetParent(transform);
        }
    }

    private void OnCollisionExit2D(Collision2D other) 
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.transform.SetParent(null);
        }
    }
}
