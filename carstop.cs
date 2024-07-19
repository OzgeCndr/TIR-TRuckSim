using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carstop : MonoBehaviour
{
    public RCC_CarControllerV3 carcode;
    // Start is called before the first frame update
    void Start()
    {
        carcode = FindObjectOfType<RCC_CarControllerV3>();
        carcode.engineRunning = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
