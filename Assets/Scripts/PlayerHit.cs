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
            // You could also use gameObject.SetActive(false) to disable the player object
            gameObject.SetActive(false);
            // Here you could also trigger any game over logic, such as displaying a game over screen
            EventManager.OnTimerStop();
        }
    }
}