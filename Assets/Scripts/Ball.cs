using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    //Reference
    [SerializeField] Paddle paddle1;

    Rigidbody2D myRigidbody;
    bool hasStarted;

    Vector2 BallToPaddleDistance;
    // Start is called before the first frame update
    void Start()
    {
        hasStarted = false;
        BallToPaddleDistance = transform.position - paddle1.transform.position;
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasStarted)
        {
            BallToPaddleLock();
            BallToLaunch();
        }

    }

    private void BallToLaunch()
    {
        if (Input.GetMouseButtonDown(0))
        {
            hasStarted = true;
            myRigidbody.velocity = new Vector2(4f, 15f);
        }
    }

    private void BallToPaddleLock()
    {
        Vector2 paddlePos = new Vector2(paddle1.transform.position.x, paddle1.transform.position.y);
        transform.position = BallToPaddleDistance + paddlePos;
    }
}
