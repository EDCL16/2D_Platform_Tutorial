using System.Collections;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [SerializeField] private Transform[] waypoints; // 設定移動點
    [SerializeField] private float speed = 2f; // 平台移動速度
    [SerializeField] private float waitTime = 1f; // 停留時間

    private int currentIndex = 0;
    private bool isWaiting = false;
    private int direction = 1; // 1 表示向前移動，-1 表示向後移動

    private void Update()
    {
        if (!isWaiting && waypoints.Length > 1)
        {
            MoveToNextWaypoint();
        }
    }

    private void MoveToNextWaypoint()
    {
        Transform target = waypoints[currentIndex];
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        if (Vector2.Distance(transform.position, target.position) < 0.05f)
        {
            StartCoroutine(WaitAtWaypoint());
        }
    }

    private IEnumerator WaitAtWaypoint()
    {
        isWaiting = true;
        yield return new WaitForSeconds(waitTime);
        
        if (currentIndex == 0) direction = 1;
        else if (currentIndex == waypoints.Length - 1) direction = -1;
        
        currentIndex += direction;
        isWaiting = false;
    }

    private void OnDrawGizmos()
    {
        if (waypoints == null) return;
        
        Gizmos.color = Color.white;
        for (int i = 0; i < waypoints.Length; i++)
        {
            if (waypoints[i] != null)
            {
                Gizmos.DrawSphere(waypoints[i].position, 0.2f);
                UnityEditor.Handles.Label(waypoints[i].position + Vector3.up * 0.3f, i.ToString());
            }
        }
    }

    public Vector2 GetCurrentSpeed()
    {
        if (isWaiting || waypoints.Length <= 1)
            return Vector2.zero;

        Vector2 directionToTarget = (waypoints[currentIndex].position - transform.position).normalized;
        return directionToTarget * speed;
    }
}
