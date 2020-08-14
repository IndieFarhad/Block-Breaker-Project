using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    Level level;



    public void Start()
    {
        level = FindObjectOfType<Level>();
        if (tag == "Breakable")
        {
            level.CountBreakableBlock();
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (tag == "Breakable")
        {
            Destroy(gameObject);
            level.DamageBlock();
        }

       
    }
}
