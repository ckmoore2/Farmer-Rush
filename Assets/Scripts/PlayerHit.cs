using UnityEngine;

public class PlayerHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the colliding object is tagged as "Enemy"
        if (collision.gameObject.tag == "Enemy")
        {
            // Implement player death logic here
            // For example, disable the player's GameObject or show a game over screen
            //gameObject.SetActive(false); // This line disables the player GameObject

            // Optionally, to destroy the player GameObject, uncomment the following line:
            //Destroy(gameObject);

            // Here you could also trigger any game over logic, such as displaying a game over screen
            Debug.Log("Game Over"); // Placeholder for game over logic
        }
    }
}