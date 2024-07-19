using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cruisecontrol : MonoBehaviour
{
    public RCC_SceneManager scenecode;
    public RCC_CarControllerV3 carcode;
    public RCC_UIController gascode;
    public Image cruisimage;
    public bool cruisecntrl;
    public float maxspeed;
    public float targetspeed;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("cek", 0.2f);
    }
    public void cek()
    {
        carcode = scenecode.activePlayerVehicle.GetComponent<RCC_CarControllerV3>();
        maxspeed = carcode.maxspeed;

    }
    public void cruiseopen()
    {
        targetspeed = carcode.speed;
        if (cruisecntrl == false & carcode.engineRunning==true) { 
            if (carcode.speed > 20f)
            {
             
                carcode.maxspeed = targetspeed;
                cruisecntrl = true;
                cruisimage.color = new Color32(57,255,57,255);
            }
    }
        else
        {
            cruiseclose();
        }
    }
    public void cruiseclose()
    {
        carcode.maxspeed = maxspeed;
            cruisecntrl = false;
        gascode.pressing = false;
        cruisimage.color = new Color32(255, 255, 255, 150);

    }
    public void cruiseiptal()
    {
        if (cruisecntrl == true & gascode.pressing == true)
        {
            carcode.maxspeed = maxspeed;
            cruisecntrl = false;
            cruisimage.color = new Color32(255, 255, 255, 150);
        }
    }
    public void gasiptal()
    {
        gascode.pressing = false;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (carcode)
        {
            if (cruisecntrl == true)
            {
                gascode.pressing = true;
            }
            if (carcode.speed < 20f & cruisecntrl == true)
            {
                cruiseclose();
            }
            if (carcode.engineRunning == false & cruisecntrl == true)
            {
                cruiseclose();
            }
        }
    }
}
