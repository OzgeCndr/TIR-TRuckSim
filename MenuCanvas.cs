using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuCanvas : MonoBehaviour
{

    public LevelManager levelcode;
    public GameObject rcccanvas;
    public GameObject missioncanvas;
    public GameObject pausecanvas;
    public GameObject finishcanvas;
    public MobileBlur blurcode;
    public GameObject Player;
    public Image Settingsbt;
    public bool settings;
    public GameObject settingspanel;
    public Image Low;
    public Image Medium;
    public Image High;
    public Image arrow;
    public Image steer;
    public Image accelo;
    public GameObject soundofimage;
    public RCC_MobileButtons mobil;
    public GameObject notice;
    public GameObject noticemoney;
    public Camera gamecamera;
    public reklamkontrol reklamcode;


    // Start is called before the first frame update
    void Start()
    {
        reklamcode = FindObjectOfType<reklamkontrol>();
        levelcode = FindObjectOfType<LevelManager>();
        Invoke("playersec", 0.5f);
        controldenetle();
        sescontrol();
        switch (QualitySettings.GetQualityLevel())

        {
            case 0:
                Low.color = Color.yellow;
                Medium.color = Color.white;
                High.color = Color.white;
                gamecamera.farClipPlane = 250;
                break;
            case 1:
                Low.color = Color.yellow;
                Medium.color = Color.white;
                High.color = Color.white;
                gamecamera.farClipPlane = 350;
                break;
            case 2:
                Low.color = Color.white;
                Medium.color = Color.yellow;
                High.color = Color.white;
                gamecamera.farClipPlane = 500;
                break;
            case 3:
                Low.color = Color.white;
                Medium.color = Color.yellow;
                High.color = Color.white;
                gamecamera.farClipPlane = 650;
                break;
            case 4:
                Low.color = Color.white;
                Medium.color = Color.yellow;
                High.color = Color.white;
                gamecamera.farClipPlane = 750;
                break;
            case 5:
                Low.color = Color.white;
                Medium.color = Color.white;
                High.color = Color.yellow;
                gamecamera.farClipPlane = 1000;
                break;
  
    }

    }
    public void geciscek()
    {
        reklamcode.interstitialAd();
    }
    public void sescontrol()
    {
        if (AudioListener.volume == 0)
        {
            soundofimage.SetActive(true);

        }
        else
        {
            soundofimage.SetActive(false);
        }
    }
    public void sesac()
    {
        if (AudioListener.volume == 0)
        {
            AudioListener.volume = 1;
        }
        else
        {
         AudioListener.volume = 0;
        }
        sescontrol();
    }
    public void controldenetle()
    {

        switch (mobil.RCCSettings.mobileController)
        {

            case RCC_Settings.MobileController.SteeringWheel:
                arrow.color = Color.white;
                steer.color = Color.yellow;
                accelo.color = Color.white;
                break;
            case RCC_Settings.MobileController.TouchScreen:
                arrow.color = Color.yellow;
                steer.color = Color.white;
                accelo.color = Color.white;

                break;
            case RCC_Settings.MobileController.Gyro:
                arrow.color = Color.white;
                steer.color = Color.white;
                accelo.color = Color.yellow;
                break;
        }
    }
    public void opsteer()
    {
        RCC.SetMobileController(RCC_Settings.MobileController.SteeringWheel);
        controldenetle();
    }
    public void opbutton()
    {

        RCC.SetMobileController(RCC_Settings.MobileController.TouchScreen);
        controldenetle();
    }
    public void opsensor()
    {
        RCC.SetMobileController(RCC_Settings.MobileController.Gyro);
        controldenetle();
    }
    public void lowsec()
    {
        Low.color = Color.yellow;
        Medium.color = Color.white;
        High.color = Color.white;
        QualitySettings.SetQualityLevel(0);
        gamecamera.farClipPlane = 250;
    }
    public void mediumsec()
    {
        Low.color = Color.white;
        Medium.color = Color.yellow;
        High.color = Color.white;
        QualitySettings.SetQualityLevel(2);
        gamecamera.farClipPlane = 750;
    }
    public void highsec()
    {
        Low.color = Color.white;
        Medium.color = Color.white;
        High.color = Color.yellow;
        QualitySettings.SetQualityLevel(5);
        gamecamera.farClipPlane = 1000;
    }
    public void playersec()
    {
        Player = GameObject.FindWithTag("Player");
    }
    public void garage()
    {
        Time.timeScale = 1f;
        reklamcode.interstitialAd();
        reklamcode.bannerAdkapa();
        Invoke("garageac", 1f);


    }
    public void garageac()
    {
        PlayerPrefs.SetString("clicklevel", "Garage");
        levelcode.levelcode.Levelsec();
        Time.timeScale = 1f;
        Time.timeScale = 1f;
    }
    public void restart()
    {
        Time.timeScale = 1f;
        reklamcode.interstitialAd();
        Invoke("restartac", 1f);

    }
    public void restartac()
    {
        PlayerPrefs.SetString("clicklevel", "GamePlay");
        levelcode.levelcode.Levelsec();
        Time.timeScale = 1f;
    }
    public void next()
    {

        blurcode.enabled = false;
        Time.timeScale = 1f;
        Invoke("noticecek", 0.5f);
        Invoke("geciscek", 1f);
    }
    public void noticecek()
    {
        notice.SetActive(true);
        noticemoney.SetActive(true);
    }
    public void pause()
    {

        Time.timeScale = 0.1f;
        blurcode.enabled = true;
        reklamcode.bannerAdac();
    }
    public void resume()
    {


        Time.timeScale = 1f;
        blurcode.enabled = false;
        settings = false;
        Settingsbt.color = Color.white;
        settingspanel.SetActive(false);
        Invoke("geciscek", 1f);
        reklamcode.bannerAdkapa();
    }
    public void blurac()
    {

        Time.timeScale = 0.1f;
        blurcode.enabled = true;

    }
    public void blurkapa()
    {

        Time.timeScale = 1f;
        blurcode.enabled = false;
        Invoke("geciscek", 1f);

    }
    public void settingsbas()
    {
        Invoke("geciscek", 1f);
        settings = !settings;
        if (settings == true)
        {
            Settingsbt.color = Color.yellow;
            settingspanel.SetActive(true);
        }
        else
        {
            Settingsbt.color = Color.white;
            settingspanel.SetActive(false);
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
  
    }
}
