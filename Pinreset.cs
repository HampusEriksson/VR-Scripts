using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pinreset : MonoBehaviour
{
    public Rigidbody rb;
    private Vector3 startPos;
    private Vector3 startRot;


    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        startRot = transform.eulerAngles;

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -2 || (rb.velocity.magnitude == 0) && (rb.angularVelocity.magnitude == 0) && transform.eulerAngles != startRot)
        {
            transform.position = new Vector3(0, 0, 2);
            transform.eulerAngles = startRot;
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;

            GameScore sn = GameObject.Find("ScoreText").GetComponent<GameScore>();
            sn.updateScore();
        }
    }

    public void ResetPostion()
    {
        transform.position = startPos;
        transform.eulerAngles = startRot;
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
    }
}
