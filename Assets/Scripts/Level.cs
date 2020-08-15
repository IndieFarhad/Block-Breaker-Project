using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    [SerializeField] int BreakableBlock;
    [SerializeField] GameObject WinLabel;
    [SerializeField] GameObject Losslabel;


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
        if(BreakableBlock <= 0)   //If No block then load winLabel
        {
            WinLabel.SetActive(true);
            Time.timeScale = 0;

        }
    }

    public void LoadNextScene()      //Next Scene Button
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void LoadRestartScene()  //Reload to CurrentScene button
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }

    
    




}
