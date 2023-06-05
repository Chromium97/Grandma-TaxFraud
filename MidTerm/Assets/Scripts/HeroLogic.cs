using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroLogic : MonoBehaviour
{

    public Animator anim;
    private BoxCollider bx;
    [SerializeField] private Vector2 axis;
    [SerializeField] private float moveSpeed = 1.2f;
    public float jumpSpeed = 4f;

    public AudioSource jumpSound;
    public AudioSource crouchSound;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        bx = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        axis.x = Input.GetAxis("Horizontal");
        axis.y = Input.GetAxis("Vertical");
        this.transform.Translate(moveSpeed * axis.y * Time.deltaTime * this.transform.forward, Space.World);

        //bx size and center used to changet the box collider based on 
        //the input used. IE crouch will make box collider smaller
        if (Input.GetKey(KeyCode.LeftControl))
        {
            if (Input.GetKey(KeyCode.W))
            {
                bx.center = new Vector3(0, 0.5f, 0);
                bx.size = new Vector3(1, 1, 1);
                anim.SetTrigger("CrouchWalk");
                crouchSound.Play();
            }
            if (Input.GetKey(KeyCode.S))
            {
                bx.center = new Vector3(0, 0.5f, 0);
                bx.size = new Vector3(1, 1, 1);
                anim.SetTrigger("CrouchWalk");
                crouchSound.Play();
            }

        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            bx.center = new Vector3(0, 1f, 0);
            bx.size = new Vector3(1, 1.9f, 1);
            anim.SetTrigger("Action");
        }
        if (Input.GetKeyDown(KeyCode.S)) {
            bx.center = new Vector3(0, 1f, 0);
            bx.size = new Vector3(1, 1.9f, 1);
            anim.SetTrigger("Back");
        }
        if (Input.GetKeyDown(KeyCode.None)) {
            bx.center = new Vector3(0, 1f, 0);
            bx.size = new Vector3(1, 1.9f, 1);
            anim.SetTrigger("Stop");
        } 
        if (Input.GetKeyDown(KeyCode.Space)) {
            bx.center = new Vector3(0, 1f, 0);
            bx.size = new Vector3(1, 1.9f, 1);
            anim.SetTrigger("Jump");
            jumpSound.Play();
            this.transform.Translate(jumpSpeed * this.transform.up, Space.World);
        }   
    }
}
