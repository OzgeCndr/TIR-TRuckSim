using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class CarClock : MonoBehaviour
{
    public GameObject clocktext;
    public GameObject disttext;
    public TMP_Text clocktexincar;
    public TMP_Text disttextincar;

    // Start is called before the first frame update
    void Start()
    {
        clocktext= GameObject.FindWithTag("clocktex");
        disttext = GameObject.FindWithTag("disttex");

    }

    // Update is called once per frame
    void FixedUpdate()
    {

            clocktexincar.text = clocktext.GetComponent<Text>().text;
            disttextincar.text = disttext.GetComponent<Text>().text;

    }
}
