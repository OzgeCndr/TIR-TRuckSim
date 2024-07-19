using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class radiobt : MonoBehaviour
{
    public GameObject radiosystem;
    public Image radiobtimage;
    public GameObject radionext;
    // Start is called before the first frame update
    void Start()
    {
        radiosystem.SetActive(false);
    }
    public void ackapa()
    {
        if (radiosystem.activeSelf == false)
        {
            radiobtimage.color = new Color32(124, 255, 0, 255);
            radiosystem.SetActive(true);
            radionext.SetActive(true);
        }
        else
        {
            radiosystem.SetActive(false);
            radiobtimage.color = new Color32(255, 255, 255, 150);
            radionext.SetActive(false);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
