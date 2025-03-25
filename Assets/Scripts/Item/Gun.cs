using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField]GameObject bulletPrefab;
    [SerializeField] float bulletSpeed =10f;

    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            GameObject bullet = Instantiate(bulletPrefab, transform.position,Quaternion.identity);

            Vector3 mousePos = Input.mousePosition;
            mousePos.z = 10f; // 設定深度，確保 `ScreenToWorldPoint` 能正確運算
            Vector3 worldMousePos = Camera.main.ScreenToWorldPoint(mousePos);

            Vector3 direction = worldMousePos - transform.position;
            direction = direction.normalized;

            bullet.GetComponent<Rigidbody2D>().linearVelocity = direction * bulletSpeed;
        }
    }
}
