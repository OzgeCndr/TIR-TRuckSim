using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finishses : MonoBehaviour
{
    public AudioSource RadioSes;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnEnable()
    {
        RadioSes.volume = 0f;  
    }
    private void OnDisable()
    {
        RadioSes.volume = 1f;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
