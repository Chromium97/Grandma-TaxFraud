using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerLogic : MonoBehaviour
{

    [SerializeField] private GameObject redCandy;
    [SerializeField] private GameObject blueCandy;
    [SerializeField] private GameObject taxForm;
    [SerializeField] public float randomNum = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnItem());
    }

    IEnumerator SpawnItem() {

        var randomShotTime = Random.Range(0.5f, 7.0f);
        yield return new WaitForSeconds(randomShotTime);

         randomNum = Random.Range(0.0f, 4.0f);

        if (((int)randomNum) == 1.0) {
            Instantiate(redCandy, transform.position, transform.rotation);
        }
        if (((int)randomNum) == 2.0)
        {
            Instantiate(blueCandy, transform.position, transform.rotation);
        }
        if (((int)randomNum) == 3.0)
        {
            Instantiate(taxForm, transform.position, transform.rotation);
        }

        StartCoroutine(SpawnItem());

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
