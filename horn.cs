using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class horn : MonoBehaviour
{
    public AudioSource hornses;
    public bool sesyuksel;
    // Start is called before the first frame update
    void Start()
    {
        hornses.volume = 0.1f;
    }
    public void hornplay()
    {
        hornses.Play();
        sesyuksel = true;

    }
    public void hornstop()
    {
    
        sesyuksel = false;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (sesyuksel == true)
        {
            if (hornses.volume < 1)
            {
                hornses.volume += Time.deltaTime*5;
            }
        }
        else
        {
        if(hornses.volume > 0.1f)
            {
                hornses.volume -= Time.deltaTime*3;
            }
            if (hornses.volume <= 0.5f)
            {
                hornses.Stop();
                hornses.volume = 0.5f;
                this.enabled = false;
            }
        }
    }
}
