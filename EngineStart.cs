using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EngineStart : MonoBehaviour
{
    public RCC_SceneManager scenecode;
    public RCC_CarControllerV3 carcode;
    public Image key;
    public AudioSource enginestopsound;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("cek", 0.2f);


    }
    public void cek()
    {
        carcode = scenecode.activePlayerVehicle.GetComponent<RCC_CarControllerV3>();
        carcode.KillOrStartEngine();
        Invoke("cek2", 2f);

    }
    public void cek2()
    {
        enginecontrol();
    }
    public void enginestopses()
    {

        if (carcode.engineRunning == true)
        {
            enginestopsound.Play();
        }
    }
        public void enginecontrol()
    {

        if (carcode.engineRunning == true)
        {
            key.color = Color.green;
        }
        else
        {
            key.color = Color.red;
        }
        Invoke("enginecontrol", 2f);

    }
    // Update is called once per frame
    void FixedUpdate()
    {

        
    }
}
