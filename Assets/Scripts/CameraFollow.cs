using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; // The player's transform
    public Vector3 offset; // Offset from the player

    void LateUpdate()
    {
        // Update camera's position to the player's position plus the offset
        transform.position = player.position + offset;
    }
}