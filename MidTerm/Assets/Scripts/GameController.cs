using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text tokenText;
    public int token = 0;

    public Text timeText;
    private float start;
    public string timeAlive = ""; 

    private bool stopped = false;

    [SerializeField] GameOverController gameOver;
    public GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        start = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (stopped) {
            gameOver.SetGameOverScreen();
            Destroy(player);
            return;
        }
            
        float timeSinceStart = Time.time - start;

        string min = ((int)timeSinceStart / 60).ToString();
        string second = (timeSinceStart % 60).ToString("f1");

        timeText.text = "Time Avoiding Tax: " + min + " : " + second;

        tokenText.text = "Candies: " + token;

        timeAlive = min + " : " + second;
    }

    public void stopTimer() 
    {
        stopped = true;
        
    }
}
