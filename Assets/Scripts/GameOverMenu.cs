using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitGameGO()
    {
        Application.Quit();
        Debug.Log("Cerro Juego!");
    }
}
