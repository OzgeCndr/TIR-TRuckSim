using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightac : MonoBehaviour
{
    public Light getlight;
    public GameObject[] LightTex;
    public bool lightactive;
    // Start is called before the first frame update
    void Start()
    {
        getlight = GetComponent<Light>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(getlight.intensity >= 0.3f)
        {
            if (lightactive == false)
            {
                for (int i = 0; i < LightTex.Length; i++)
                {
                    LightTex[i].SetActive(true);
                }
                lightactive = true;
            }
            
        }
        else
        {
            if (lightactive == true)
            {
                for (int i = 0; i < LightTex.Length; i++)
                {
                    LightTex[i].SetActive(false);
                }
                lightactive = false;
            }
        }
    }
}
