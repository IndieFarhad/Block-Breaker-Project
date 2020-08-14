using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField] int BreakableBlock;
    [SerializeField] GameObject WinLabel;


    public void CountBreakableBlock()
    {
        WinLabel.SetActive(false);
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
