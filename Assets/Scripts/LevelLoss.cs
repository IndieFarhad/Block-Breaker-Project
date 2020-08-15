using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLoss : MonoBehaviour
{
    [SerializeField] GameObject LossLabel;


    // Start is called before the first frame update
    void Start()
    {
        LossLabel.SetActive(false);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        LossLabel.SetActive(true);
    }

}
