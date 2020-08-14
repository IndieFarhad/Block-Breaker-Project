using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField] int BreakableBlock;


    public void CountBreakableBlock()
    {
        BreakableBlock++;
    }


    public void DamageBlock()
    {
        BreakableBlock--;
    }



    
}
