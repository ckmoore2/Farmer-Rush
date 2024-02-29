using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverScreen;

    public SpawnManager spawnManager; // The SpawnManager script
    public Transform player; // The player's transform

    private void OnTriggerEnter(Collider other)
    {
        GameOver();
    }

    void Update()
    {
        // Check if the player presses the "Escape" key
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            GameOver();
        }
        if (player == null) // Use double equals for comparison
        {
            GameOver();
        }
    }

    void GameOver()
    {
        // Set the game over flag

        // Stop spawning animals
         if (spawnManager != null)
        {
            spawnManager.GameOver();
        };

        // Show the game over screen
        if (gameOverScreen != null)
        {
            gameOverScreen.SetActive(true);
        }

        // You can add more game over logic here, such as stopping gameplay, showing final score, etc.

        // You can add any code here to handle the game-ending logic
        Debug.Log("Game Over!"); // For example, you can print a message to the console

        // You might want to trigger other actions, such as showing a game over screen, playing a sound, etc.

        // Optionally, you can quit the application (this is just an example)
        // Note: Application.Quit() might not work in all deployment platforms
        // It's generally used in standalone builds, not in the Unity Editor
        #if UNITY_STANDALONE
        Application.Quit();
        #endif
    }
}
