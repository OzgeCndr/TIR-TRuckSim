using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oneable : MonoBehaviour
{
    public GameObject acilcak;
    public GameObject kapat;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnEnable()
    {
        acilcak.SetActive(true);
    }
    public void OnDisable()
    {
        acilcak.SetActive(false);
        kapat.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
