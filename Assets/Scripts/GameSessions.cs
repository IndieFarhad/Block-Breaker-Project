using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSessions : MonoBehaviour
{
    [Range(0.1f, 10f)] [SerializeField] float GameSpeed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = GameSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
