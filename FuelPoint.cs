using UnityEngine;
using UnityEngine.UI;

public class FuelPoint : MonoBehaviour
{
    public Image fuelvalue;
    public float fuelup;
    public float fuelmoney;
    public GameObject fuelnotmoneycanvas;
    public CarManager carcode;
    private bool girdi;
    public GameObject notice;
    public GameObject noticefuelmoney;
    public GameObject noticefuelup;
    public Text noticemoneytex;
    public bool doldur = false;
    public GameObject ropeobject;
    public ropesystem ropecode;
    public GameObject fuelpump;
    public MissionSystem missioncode;
    // Start is called before the first frame update
    void Start()
    {
        missioncode= FindObjectOfType<MissionSystem>();
        carcode = FindObjectOfType<CarManager>();
        ropecode = ropeobject.GetComponent<ropesystem>();

    }
    private void OnEnable()
    {
        ropecode.enabled = true;
        Invoke("ropekapa", 0.5f);
    }
    public void ropekapa()
    {
        ropecode.enabled = false;
    }
    public void girdikapa()
    {
        girdi = false;
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.name == "carcol")
        {
            ropecode.enabled = true;
            fuelup = 1f - fuelvalue.fillAmount;
            fuelmoney = fuelup * 5000;
            ropeobject.SetActive(true);
            if (doldur == false)
            {

                if (girdi == false)
                {

               
                    CancelInvoke("girdikapa");
                  
                    girdi = true;
                    Invoke("girdikapa", 10f);
                }


        
 
                if (fuelvalue.fillAmount < 0.98f)
                {

                    if (PlayerPrefs.GetInt("money") > fuelmoney)
                    {
                        doldur = true;
                        carcode.Selectcar.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
                        notice.SetActive(false);
                        notice.SetActive(true);
                        noticefuelup.SetActive(true);
                        PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") - (int)fuelmoney);
                        noticemoneytex.text = "-" + (int)fuelmoney + " $";
      

                    }
                    else
                    {
                        fuelnotmoneycanvas.SetActive(true);
                        carcode.Selectcar.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;

                    }
                }
            }
        }
    }
    public void gecisac()
    {
        missioncode.geciscek();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (doldur == true)
        {

            fuelvalue.fillAmount += Time.deltaTime / 15f;
            fuelpump.SetActive(true);
            ropecode.active = true;
            if (fuelvalue.fillAmount >= 1)
            {
                fuelpump.SetActive(false);
                ropecode.active = false;
                carcode.Selectcar.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
                notice.SetActive(false);
                notice.SetActive(true);
                noticefuelmoney.SetActive(true);
                doldur = false;
                Invoke("ropekapa", 3f);
                Invoke("gecisac", 3f);
     
            }
        }
    }
}
