using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMode : MonoBehaviour
{
    public static bool gameLost;
    public static bool gameWon;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (PickUpCandy.candiesCollected == 3)
        {
            Victory();
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("zombie"))
        {
            gameWon = false;
            gameLost = true;
            SwapScenes.GameOver();
        }
    }

    private void Victory()
    {
        gameLost = false;
        gameWon = true;
        SwapScenes.Victory();
    }
}
