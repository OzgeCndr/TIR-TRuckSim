using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficCarLight : MonoBehaviour
{
    public WeatherSystem timecode;
    public GameObject lightobject;
    // Start is called before the first frame update
    void Start()
    {
        timecode = FindObjectOfType<WeatherSystem>();
        if (timecode.daybool == true)
        {
            lightobject.SetActive(false);
        }
        else
        {
            lightobject.SetActive(true);
        }
    }
    private void OnEnable()
    {
        if (timecode.daybool == true)
        {
            lightobject.SetActive(false);
        }
        else
        {
            lightobject.SetActive(true);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
