using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Declaration des attributs et class de unity native
    [SerializeField] private Transform player;
    void Update()
    {
        // Systeme de deplacement de la camera par rapport au deplacement du joueur
        transform.position = new Vector3(player.position.x + 2, player.position.y + 1, transform.position.z);
    }
}