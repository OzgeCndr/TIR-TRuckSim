using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gasoline : MonoBehaviour
{
    public GameObject points;
    // Start is called before the first frame update
    void Start()
    {
        points.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.name == "carcol")
        {
            points.SetActive(true);
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.name == "carcol")
        {
            points.SetActive(false);
        }
    }
}
