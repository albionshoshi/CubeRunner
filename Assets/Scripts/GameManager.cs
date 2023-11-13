using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1f;

    public GameObject CompleteLevelUI;

    public void CompleteLevel()
    {
        CompleteLevelUI.SetActive(true); //Can set to true/false depenpending on if you want the complete
                                         //level to show
    }
    public void GameOver()
    {

        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over!"); // game over tag implemented in player collision
            Invoke("Restart", restartDelay); // function that takes in 2 parameters
                                            // restart function and varibale restart delay
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); //loads scene with given name and displays name of where player is
    }
}

