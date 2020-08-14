using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField] int BreakableBlock;
    [SerializeField] GameObject WinLabel;


    public void Start()
    {
        WinLabel.SetActive(false);

    }

    public void CountBreakableBlock()
    {
        BreakableBlock++;
    }


    public void DamageBlock()
    {
        BreakableBlock--;
        if(BreakableBlock <= 0)
        {
            WinLabel.SetActive(true);
            Time.timeScale = 0;
        }
    }



    
}
