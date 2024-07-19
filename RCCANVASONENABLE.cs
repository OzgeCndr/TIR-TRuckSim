using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RCCANVASONENABLE : MonoBehaviour
{
    public GameObject eventsystem;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnEnable()
    {
        eventsystem.SetActive(false);
        eventsystem.SetActive(true);
        eventsystem.SetActive(false);
        Invoke("eventac", 1f);
    }
    public void eventac()
    {
        eventsystem.SetActive(false);
        eventsystem.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
