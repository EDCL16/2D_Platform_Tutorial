using UnityEngine;

public class RotationPlatform : MonoBehaviour
{
    [SerializeField] float rotationSpeed;
    void Update()
    {
        transform.rotation *= Quaternion.Euler(0, 0, rotationSpeed * Time.deltaTime);
    }
}
