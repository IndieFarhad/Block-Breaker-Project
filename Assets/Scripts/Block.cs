using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    Ball ball;

    public void Start()
    {
        ball = FindObjectOfType<Ball>();
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (tag == "Breakable")
        {
            Destroy(gameObject);
        }

       
    }
}
