using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStarter : MonoBehaviour
{
    // Method to be called when the Play button is pressed
    public void StartGame()
    {
        // Load the next scene or start the game logic
        // Assuming your game scene is called "GameScene"
        SceneManager.LoadScene("SampleScene");
    }
}
