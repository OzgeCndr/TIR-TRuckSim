using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    public Animator Driveranimator;
    public RCC_CarControllerV3 carcode;
    // Start is called before the first frame update
    void Start()
    {
        carcode = gameObject.GetComponent<RCC_CarControllerV3>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        Driveranimator.SetFloat("steer", carcode.steerInput);

    }
}
