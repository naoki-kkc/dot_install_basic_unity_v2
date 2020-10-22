using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallFactroryScript : MonoBehaviour
{

    public GameObject ball;

    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(ball, transform.position, transform.rotation);
        InvokeRepeating("SpawnBall", 0f, 1f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnBall()
    {
        float randomX = Random.Range(-5f, 5f);
        Instantiate(ball, new Vector3(randomX, transform.position.y, transform.position.z), transform.rotation);
    }
}
