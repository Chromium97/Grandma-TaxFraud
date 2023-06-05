using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaxForm : MonoBehaviour
{

    public GameController gameController;
    
   

    // Start is called before the first frame update
    void Start()
    {
        gameController = GameObject.Find("Canvas").GetComponent<GameController>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            gameController.stopTimer();
          
        }
    }
}
