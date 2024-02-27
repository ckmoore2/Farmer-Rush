using UnityEngine;

public class PlayerHit : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Check if the colliding object is tagged as "Enemy"
        if (other.CompareTag("Enemy"))
        {
            // Implement player death logic here
            Debug.Log("Player hit by enemy. Game Over!");
            Destroy(gameObject); // Destroys the player object

            // Here you could also trigger any game over logic, such as displaying a game over screen
        }
    }
}