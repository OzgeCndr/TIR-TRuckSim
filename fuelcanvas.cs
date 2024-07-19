using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class fuelcanvas : MonoBehaviour
{
    public Image fuelvalue;
    public GameObject fuellowcanvas;

    // Start is called before the first frame update
    void Start()
    { 

    }
    public void mazotverreklam()
    {
        fuelvalue.fillAmount = fuelvalue.fillAmount + 0.5f;
        fuellowcanvas.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
