using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //setting movement speed
    public float moveSpeed = 1.7f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-moveSpeed * Time.deltaTime, 0f, 0f);
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Spawner") {
            Invoke("DestroyCollisionObj", 0f);
        }
    }

    private void DestroyCollisionObj()
    {
        Destroy(this.gameObject);
    }
}
