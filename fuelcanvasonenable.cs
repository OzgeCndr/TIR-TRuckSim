using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fuelcanvasonenable : MonoBehaviour
{
    public GameObject kapat;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnEnable()
    {
        kapat.SetActive(false);
    }

  private void OnDisable()
    {
        kapat.SetActive(true);
    }
}
