using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TokenAdd : MonoBehaviour
{
    public GameController gameController;
    public AudioClip tokenSound;
    public string name;



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
        //Detecting collision
        if (collision.gameObject.tag == "Player")
        {
            //Audio to play when token is collected
            AudioSource.PlayClipAtPoint(tokenSound, transform.position);
        }
        if (name == "Red") {
            gameController.token += 5;
        }
        if (name == "Blue")
        {
            gameController.token += 3;
        }



    }
}
