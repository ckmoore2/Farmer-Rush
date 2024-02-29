using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; // The player's transform
    public Vector3 offset; // Offset from the player

    void LateUpdate()
    {
        // Check if the player exists
        if (player != null)
        {
            // Update camera's position to the player's position plus the offset
            transform.position = player.position + offset;
        }
        else
        {
            // The player is destroyed - add your end-game actions here
            Debug.Log("Player destroyed - Game Over");
        }
    }
}
