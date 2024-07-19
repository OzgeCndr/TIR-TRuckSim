 using UnityEngine;
using UnityEngine.UI;

public class MissionSystem : MonoBehaviour
{

    public int spawnpoint;
    public int selectmoney;
    public GameObject jobtriggers;
    public GameObject notice;
    public GameObject noticeintrailer;
    public GameObject noticetarget;
    public Text noticemoneytex;
    public GameObject SelectTrailer;
    private bool noticetargetbool;
    public GameObject[] trailerpoints;
    public GameObject[] Trailers;
    public GameObject trailerselectpoint;
    public bool missionactive;
    public bool trailerattached;
    public CarManager carcode;
    public GameObject SelectCar;
    public GameObject[] MissionTargets;
    public Text[] MissionDistanceTex;
    public Text[] MissionMoneyTex;
    public int[] missionmoney;
    public GameObject FinishObject;
    public MenuCanvas canvascode;
    public FinishCanvas finishcode;
    public GameObject attachsound;
    public RCC_Camera camcode;
    public reklamkontrol reklamcode;
    public GameObject adscoming;

    // Start is called before the first frame update
    void Start()
    {
        reklamcode = FindObjectOfType<reklamkontrol>();
        carcode = FindObjectOfType<CarManager>();
        Invoke("cek", 0.3f);
        trailerattached = false;
        camcode = FindObjectOfType<RCC_Camera>();
        Invoke("adsac", 75f);


    }
    public void adsac()
    {
        adscoming.SetActive(true);
        Invoke("adsac", 75f);
    }
    public void geciscek()
    {
        reklamcode.interstitialAd();
    }
    public void cek()
    {
        SelectCar = carcode.Selectcar;
        trailerspawnselect();
        canvascode = Object.FindObjectOfType<MenuCanvas>();
        FinishObject.SetActive(true);
    }

    public void job1()
    {
        if (missionactive == false)
        {
            notice.SetActive(true);
            noticeintrailer.SetActive(true);
            Instantiate(Trailers[0], trailerselectpoint.transform.position, trailerselectpoint.transform.rotation);
            FinishObject.SetActive(true);
            missionactive = true;
           FinishObject.transform.position = MissionTargets[0].transform.position;
           FinishObject.transform.rotation = MissionTargets[0].transform.rotation;
            selectmoney = missionmoney[0];
            finishcode.money = selectmoney;
            noticemoneytex.text = "+"+finishcode.money + "$";
            FinishObject.SetActive(false);
            SelectCar.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            canvascode.blurcode.enabled = false;
            jobtriggers.SetActive(false);
            SelectCar.transform.position = carcode.spawnpoints[spawnpoint].transform.position;
            SelectCar.transform.rotation = carcode.spawnpoints[spawnpoint].transform.rotation;
            Invoke("geciscek", 1f);

        }
    }
    public void job2()
    {
        if (missionactive == false)
        {
            notice.SetActive(true);
            noticeintrailer.SetActive(true);
            Instantiate(Trailers[1], trailerselectpoint.transform.position, trailerselectpoint.transform.rotation);
            FinishObject.SetActive(true);
            missionactive = true;
            FinishObject.transform.position = MissionTargets[1].transform.position;
            FinishObject.transform.rotation = MissionTargets[1].transform.rotation;
            selectmoney = missionmoney[1];
            finishcode.money = selectmoney;
            noticemoneytex.text = "+" + finishcode.money + "$";
            FinishObject.SetActive(false);
            SelectCar.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            canvascode.blurcode.enabled = false;
            jobtriggers.SetActive(false);
            SelectCar.transform.position = carcode.spawnpoints[spawnpoint].transform.position;
            SelectCar.transform.rotation = carcode.spawnpoints[spawnpoint].transform.rotation;
            Invoke("geciscek", 1f);
        }
    }
    public void job3()
    {
        if (missionactive == false)
        {
            notice.SetActive(true);
            noticeintrailer.SetActive(true);
            Instantiate(Trailers[2], trailerselectpoint.transform.position, trailerselectpoint.transform.rotation);
            FinishObject.SetActive(true);
            missionactive = true;
            FinishObject.transform.position = MissionTargets[2].transform.position;
            FinishObject.transform.rotation = MissionTargets[2].transform.rotation;
            selectmoney = missionmoney[2];
            finishcode.money = selectmoney;
            noticemoneytex.text = "+" + finishcode.money + "$";
            FinishObject.SetActive(false);
            SelectCar.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            canvascode.blurcode.enabled = false;
            jobtriggers.SetActive(false);
            SelectCar.transform.position = carcode.spawnpoints[spawnpoint].transform.position;
            SelectCar.transform.rotation = carcode.spawnpoints[spawnpoint].transform.rotation;
            Invoke("geciscek", 1f);
        }
    }
    public void job4()
    {
        if (missionactive == false)
        {
            notice.SetActive(true);
            noticeintrailer.SetActive(true);
            Instantiate(Trailers[3], trailerselectpoint.transform.position, trailerselectpoint.transform.rotation);
            FinishObject.SetActive(true);
            missionactive = true;
            FinishObject.transform.position = MissionTargets[3].transform.position;
            FinishObject.transform.rotation = MissionTargets[3].transform.rotation;
            selectmoney = missionmoney[3];
            finishcode.money = selectmoney;
            noticemoneytex.text = "+" + finishcode.money + "$";
            FinishObject.SetActive(false);
            SelectCar.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            canvascode.blurcode.enabled = false;
            jobtriggers.SetActive(false);
            SelectCar.transform.position = carcode.spawnpoints[spawnpoint].transform.position;
            SelectCar.transform.rotation = carcode.spawnpoints[spawnpoint].transform.rotation;
            Invoke("geciscek", 1f);
        }
    }
    public void job5()
    {
        if (missionactive == false)
        {
            notice.SetActive(true);
            noticeintrailer.SetActive(true);
            Instantiate(Trailers[4], trailerselectpoint.transform.position, trailerselectpoint.transform.rotation);
            FinishObject.SetActive(true);
            missionactive = true;
            FinishObject.transform.position = MissionTargets[4].transform.position;
            FinishObject.transform.rotation = MissionTargets[4].transform.rotation;
            selectmoney = missionmoney[4];
            finishcode.money = selectmoney;
            noticemoneytex.text = "+" + finishcode.money + "$";
            FinishObject.SetActive(false);
            SelectCar.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            canvascode.blurcode.enabled = false;
            jobtriggers.SetActive(false);
            SelectCar.transform.position = carcode.spawnpoints[spawnpoint].transform.position;
            SelectCar.transform.rotation = carcode.spawnpoints[spawnpoint].transform.rotation;
            Invoke("geciscek", 1f);
        }
    }
    public void trailerspawnselect()
    {
        switch (spawnpoint)
        {
            case 0:
                trailerselectpoint = trailerpoints[0];
                MissionTargets[0] = trailerpoints[1];
                MissionTargets[1] = trailerpoints[2];
                MissionTargets[2] = trailerpoints[3];
                MissionTargets[3] = trailerpoints[4];
                MissionTargets[4] = trailerpoints[5];



                break;

            case 1:
                trailerselectpoint = trailerpoints[1];
                MissionTargets[0] = trailerpoints[0];
                MissionTargets[1] = trailerpoints[2];
                MissionTargets[2] = trailerpoints[3];
                MissionTargets[3] = trailerpoints[4];
                MissionTargets[4] = trailerpoints[5];
              
                break;

            case 2:
                trailerselectpoint = trailerpoints[2];
                MissionTargets[0] = trailerpoints[1];
                MissionTargets[1] = trailerpoints[0];
                MissionTargets[2] = trailerpoints[3];
                MissionTargets[3] = trailerpoints[4];
                MissionTargets[4] = trailerpoints[5];
                
                break;

            case 3:
                trailerselectpoint = trailerpoints[3];
                MissionTargets[0] = trailerpoints[1];
                MissionTargets[1] = trailerpoints[2];
                MissionTargets[2] = trailerpoints[0];
                MissionTargets[3] = trailerpoints[4];
                MissionTargets[4] = trailerpoints[5];
              
                break;

            case 4:
                trailerselectpoint = trailerpoints[4];
                MissionTargets[0] = trailerpoints[1];
                MissionTargets[1] = trailerpoints[2];
                MissionTargets[2] = trailerpoints[3];
                MissionTargets[3] = trailerpoints[0];
                MissionTargets[4] = trailerpoints[5];
              
                break;

            case 5:
                trailerselectpoint = trailerpoints[5];
                MissionTargets[0] = trailerpoints[1];
                MissionTargets[1] = trailerpoints[2];
                MissionTargets[2] = trailerpoints[3];
                MissionTargets[3] = trailerpoints[4];
                MissionTargets[4] = trailerpoints[0];
               
                break;

        }
        //Distance
        MissionDistanceTex[0].text = Vector3.Distance(SelectCar.transform.position, MissionTargets[0].transform.position).ToString("F0") + " KM";
        MissionDistanceTex[1].text = Vector3.Distance(SelectCar.transform.position, MissionTargets[1].transform.position).ToString("F0") + " KM";
        MissionDistanceTex[2].text = Vector3.Distance(SelectCar.transform.position, MissionTargets[2].transform.position).ToString("F0") + " KM";
        MissionDistanceTex[3].text = Vector3.Distance(SelectCar.transform.position, MissionTargets[3].transform.position).ToString("F0") + " KM";
        MissionDistanceTex[4].text = Vector3.Distance(SelectCar.transform.position, MissionTargets[4].transform.position).ToString("F0") + " KM";
        //Money
        missionmoney[0] = (int)Vector3.Distance(SelectCar.transform.position, MissionTargets[0].transform.position) * 5;
        missionmoney[1] = (int)Vector3.Distance(SelectCar.transform.position, MissionTargets[1].transform.position) * 5;
        missionmoney[2] = (int)Vector3.Distance(SelectCar.transform.position, MissionTargets[2].transform.position) * 5;
        missionmoney[3] = (int)Vector3.Distance(SelectCar.transform.position, MissionTargets[3].transform.position) * 5;
        missionmoney[4] = (int)Vector3.Distance(SelectCar.transform.position, MissionTargets[4].transform.position) * 5;
        //MoneyTex
        MissionMoneyTex[0].text = missionmoney[0].ToString() + " $";
        MissionMoneyTex[1].text = missionmoney[1].ToString() + " $";
        MissionMoneyTex[2].text = missionmoney[2].ToString() + " $";
        MissionMoneyTex[3].text = missionmoney[3].ToString() + " $";
        MissionMoneyTex[4].text = missionmoney[4].ToString() + " $";
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (trailerattached == true)
        {
            attachsound.SetActive(true);
         
            Invoke("noticeac", 1f);
            if (camcode.trailer == false)
            {
                camcode.trailer = true;
            }
        }
        else
        {
            attachsound.SetActive(false);
            if (noticetargetbool == true)
            {
                Invoke("noticekapa", 2f);
            }
            if (camcode.trailer == true)
            {
                camcode.trailer = false;
            }

        }
    }
    public void noticeac()
    {
        if (noticetargetbool == false)
        {
            FinishObject.SetActive(true);
            noticetargetbool = true;
            notice.SetActive(true);
            noticetarget.SetActive(true);
        }
    }
    public void noticekapa()
    {
        noticetargetbool = false;
        CancelInvoke();
    }
}
