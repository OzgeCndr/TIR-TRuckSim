using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuelDash : MonoBehaviour
{
    public GameObject fueldash;
    public Image fueldash2;
    public GameObject lowfueldash;
    public bool fueldash2active;


    public float fueldashf;

    // Start is called before the first frame update
    void Start()
    {
        lowfueldash.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
