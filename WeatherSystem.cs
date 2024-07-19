using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class WeatherSystem : MonoBehaviour
{
    public Material daysky;
    public Material nightsky;
    public Cubemap dayprobe;
    public Cubemap nightprobe;
    public GameObject daylight;
    public GameObject nightlight;
    public bool daybool;
    public bool nightbool;
    public float Clock;
    public Text clocktex;

    // Start is called before the first frame update
    void Start()
    {

        Clock = Random.Range(0,1440);
    }
    void FixedUpdate()
    {

        Clock += Time.deltaTime;
        int minutes = Mathf.FloorToInt(Clock / 60.0f);
        int seconds = Mathf.FloorToInt(Clock - minutes * 60);
        clocktex.text = string.Format("{0:00} {1:00}", minutes, seconds).ToString();
        if (Clock > 1440)
        {
            Clock = 0f;
        }
        if(Clock>1200 | Clock <480)
        {
            if (nightbool != true)
            {
                night();
                Debug.Log("night");
            }
        }
        else
        {
            if (daybool != true)
            {
                Debug.Log("day");
                day();
            }
        }
       

    }
    void ClockTime()
    {

    }
    public void day()
    {
        daybool = true;
        nightbool = false;
        RenderSettings.fogColor = new Color32(234, 197, 145, 255);
        RenderSettings.customReflection = dayprobe;
        RenderSettings.skybox = daysky;
        daylight.SetActive(true);
        nightlight.SetActive(false);
    }
    public void night()
    {
        daybool = false;
        nightbool = true;
        RenderSettings.fogColor = new Color32(10, 10, 10, 255);
        RenderSettings.customReflection = nightprobe;
        RenderSettings.skybox = nightsky;
        daylight.SetActive(false);
        nightlight.SetActive(true);
    }
    // Update is called once per frame

}
