using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fuelui : MonoBehaviour
{
    private bool start = false;
    public Image fuelvalue;
    public Text fuelvaluetex;
    public GameObject fuelnorm;
    public GameObject fuellow;
    public RCC_UIController gascode;
    public bool valuedown=false;
    public float valueint;
    public Button enginestart;
    public float fuelrunning;
    public RCC_UIDashboardButton enginestartcode;
    public RCC_SceneManager scenecode;
    public RCC_CarControllerV3 carcode;
    public GameObject startarrow;
    public GameObject fuellowcanvas;
    public FuelDash fuelcode;
    public GameObject fueldashs;
    public GameObject lowfueldash;
    public float fueldashf;
    public bool noticefuel;
    public GameObject notice;
    public GameObject noticefuelin;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("cek", 0.2f);
        Invoke("starttrue", 2f);
    }
    public void starttrue()
    {
        start = true;
    }
    public void cek()
    {
        carcode = scenecode.activePlayerVehicle.GetComponent<RCC_CarControllerV3>();
        fuelcode = scenecode.activePlayerVehicle.GetComponent<FuelDash>();
        fueldashs = fuelcode.fueldash;
        fueldashf = fuelcode.fueldashf;
        lowfueldash= fuelcode.lowfueldash;
        lowfueldash.SetActive(false);

    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (fuelcode!=null && fuelcode.fueldash2active == true && fuelcode.fueldash2 != null)
        {
         
                fuelcode.fueldash2.fillAmount = fuelvalue.fillAmount;
            
        }
        if (carcode)
        {
            if (fueldashs != null)
            {
                fueldashs.transform.localRotation = Quaternion.AngleAxis(-fueldashf * fuelvalue.fillAmount, Vector3.forward);
            }
            fuelvalue.fillAmount = fuelvalue.fillAmount - fuelrunning;
            if (gascode.pressing == true)
            {
                valuedown = true;
            }
            else
            {
                valuedown = false;
            }
            valueint = fuelvalue.fillAmount * 100;
            fuelvaluetex.text = "%" + valueint.ToString("F0");
            if (carcode.engineRunning == true)
            {
                fuelrunning = 0.00001f;
                if (valuedown == true)
                {
                    fuelrunning = 0.00005f;
                }

            }
            else
            {
                fuelrunning = 0f;
            }
            if (fuelvalue.fillAmount > 0.8f)
            {
                fuelvalue.color = new Color32(139, 255, 0, 255);
                fuelnorm.GetComponent<Image>().color = Color.white;
                fuelnorm.SetActive(true);

                fuellow.SetActive(false);
                lowfueldash.SetActive(false);
                noticefuel = false;
            }
            if (fuelvalue.fillAmount < 0.5f & fuelvalue.fillAmount > 0.2f)
            {
                fuelvalue.color = new Color32(255, 158, 0, 255);
                fuelnorm.GetComponent<Image>().color = new Color32(255, 158, 0, 255);
                fuelnorm.SetActive(true);
                fuellow.SetActive(false);
                lowfueldash.SetActive(false);
                noticefuel = false;
            }
            if (fuelvalue.fillAmount < 0.2f)
            {
                fuelvalue.color = Color.red;
                fuelnorm.SetActive(false);
                fuellow.SetActive(true);
                lowfueldash.SetActive(true);
                if (noticefuel == false)
                {
                    noticefuel = true;
                    notice.SetActive(true);
                    noticefuelin.SetActive(true);

                }
            }
            if (fuelvalue.fillAmount < 0.01f)
            {
                enginestart.interactable = false;
                enginestartcode.enabled = false;
                carcode.engineRunning = false;
                fuelvalue.fillAmount = 0f;
                fuellowcanvas.SetActive(true);
            }
            else
            {
                enginestart.interactable = true;
                enginestartcode.enabled = true;
                fuellowcanvas.SetActive(false);
            }
            if (fuelvalue.fillAmount > 0.2f & carcode.engineRunning == false)
            {
                if (start == true)
                {
                    startarrow.SetActive(true);
                }
            }
            else
            {
                startarrow.SetActive(false);
            }

        }
    }
}
