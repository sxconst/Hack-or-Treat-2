using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwapScenes : MonoBehaviour
{
    public static void GameOver()
    {
        SceneManager.LoadScene(2);
        Cursor.lockState = CursorLockMode.None;
    }

    public static void Victory()
    {
        SceneManager.LoadScene(3);
        Cursor.lockState = CursorLockMode.None;
    }
    
    public static void PlayGame()
    {
        Time.timeScale = 1f;
        GameMode.gameLost = false;
        GameMode.gameWon = false;
        ZombieMovement.zombieShouldMove = true;
        PickUpCandy.candiesCollected = 0;
        SpawnCandy.numberOfCandies = 0;
        SpawnCandy.spawnCandy = true;
        SceneManager.LoadScene(1);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void ExitApplication()
    {
        Application.Quit();
    }
}
