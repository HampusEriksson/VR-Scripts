using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    public Rigidbody rb;
    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -2)
        {
            transform.position = startPos;
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;

        }

        if (transform.position.x < -5)
        {
            GameScore sn = GameObject.Find("ScoreText").GetComponent<GameScore>();
            sn.updateTries();

        }

    }

    
}
