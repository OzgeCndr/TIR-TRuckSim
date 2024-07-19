using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraset : MonoBehaviour
{
    public RCC_Camera camcode;
    public MissionSystem missioncode;
    [Header("Truck Camera Settings")]
    public float tpsdist;
    public float tpsheigh;
    public float tpspitch;
    [Header("Trailer Camera Settings")]

    public float trailertpsdist;
    public float trailertpsheigh;
    public float trailertpspitch;
    [Header("Hood Camera Settings")]
    public float hoodx;
    public float hoody;
    public float hoodmaxorbity;
    private float orbitydefault;
    public GameObject drivercharacter;
    public GameObject hoodmirror;
    public GameObject minimapincar;

    public bool cameraok;


    // Start is called before the first frame update
    void Awake()
    {
        camcode = Object.FindObjectOfType<RCC_Camera>();
        missioncode = FindObjectOfType<MissionSystem>();
        orbitydefault = camcode.maxOrbitY;


        minimapincar.SetActive(false);
    }
    private void Start()
    {

        Invoke("hoodkapa", 1f);
        camcode.TPSDistance = tpsdist;
        camcode.TPSHeight = tpsheigh;
        camcode.TPSPitch = tpspitch;
    }
    public void hoodkapa()
    {
        hoodmirror.SetActive(false);
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        if (missioncode.trailerattached == false)
        {
            if (cameraok == false)
            {
                camcode.TPSDistance = tpsdist;
                camcode.TPSHeight = tpsheigh;
                camcode.TPSPitch = tpspitch;
                cameraok = true;

            }
        }
        else
        {
            if(cameraok == true)
            {
                camcode.TPSDistance = trailertpsdist;
                camcode.TPSHeight = trailertpsheigh;
                camcode.TPSPitch = trailertpspitch;
                cameraok = false;
            }
        }

        if (camcode != null)
        {
            if (camcode.hoodx != hoodx)
            {
                camcode.hoodx = hoodx;
            }
            if (camcode.hoody != hoody)
            {
                camcode.hoody = hoody;
            }
            if (camcode.hoodactive == true)
            {
                if (drivercharacter.activeInHierarchy == true)
                {
                    drivercharacter.SetActive(false);
                    camcode.maxOrbitY = hoodmaxorbity;
                    hoodmirror.SetActive(true);
                    minimapincar.SetActive(true);
                    CancelInvoke("hoodkapa");
                }
            }
            else
            {
                if (drivercharacter.activeInHierarchy == false)
                {
                    drivercharacter.SetActive(true);
                    camcode.maxOrbitY = orbitydefault;
                    hoodmirror.SetActive(false);
                    minimapincar.SetActive(false);
                }
            }
        }
    }
}
