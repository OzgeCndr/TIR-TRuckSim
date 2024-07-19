using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mmapiconenable : MonoBehaviour
{
    public GameObject[] mapdetay;
    // Start is called before the first frame update
    void Start()
    {

    }
    void OnEnable()
    {
        for (int i = 0; i < mapdetay.Length; i++)
        {
            mapdetay[i].SetActive(true);
        }

    }
    void OnDisable()
    {
        for (int i = 0; i < mapdetay.Length; i++)
        {
            mapdetay[i].SetActive(false);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
