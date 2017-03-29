using UnityEngine;

[RequireComponent(typeof(EnemyBeh))]
public class EnemyMovement : MonoBehaviour
{
    private Transform target;
    private int waypointIndex = 0;
    private EnemyBeh enemy;


    void Start()
    {
        target = Waypoints.waypoints[0];
        enemy = GetComponent<EnemyBeh>();
    }

    void Update()
    {
        Vector3 direction = target.position - transform.position;
        transform.Translate(direction.normalized * enemy.speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) <= 0.2f)
        {
            GetNextWaypoint();
        }
        enemy.speed = enemy.startSpeed;
    }

    void GetNextWaypoint()
    {
        if (waypointIndex >= Waypoints.waypoints.Length - 1)
        {
            EndPath();
            return;
        }
        waypointIndex++;
        target = Waypoints.waypoints[waypointIndex];
    }

    void EndPath()
    {
        //PlayerStats.lives--;
        Destroy(gameObject);
        EnemySpawner.EnemiesAlive--;
    }
}
