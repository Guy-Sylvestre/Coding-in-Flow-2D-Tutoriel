using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFollower : MonoBehaviour
{
    // Declaration des attributs et class de unity native
    [SerializeField] private GameObject[] waypoints;
    [SerializeField] private float speed = 2f;
    private int currentWaypointIndex = 0;

    void Update()
    {
        // Systeme de deplacement d'un object entre deux points definir en 2D
        if (Vector2.Distance(waypoints[currentWaypointIndex].transform.position, transform.position ) < .1f)
        {
            currentWaypointIndex ++;
            if (currentWaypointIndex >= waypoints.Length)
            {
                currentWaypointIndex = 0;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, waypoints[currentWaypointIndex].transform.position, Time.deltaTime * speed);
    }
}
