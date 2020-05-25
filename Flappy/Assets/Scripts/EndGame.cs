using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGame : MonoBehaviour
{
    public GameObject endGame;
    public GameObject player;
    public bool gameOver = false;
    // Start is called before the first frame update
    void Start()
    {
        endGame.SetActive(false);
    }

    public void End()
    {
        
            gameOver = true;
        Destroy(player);
        endGame.SetActive(true);
    }
}
