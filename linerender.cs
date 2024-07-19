using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
public class linerender : MonoBehaviour
{

    public GameObject bitis;
    public MissionSystem missioncode;
    public NavMeshAgent navmesh;
    public Text Distance;
    public float navmeshreset;
    private float count;
    public bool cizgiacik;
    public bool navmeshzerobool;
    
    // Start is called before the first frame update
    void Start()
    {
        missioncode = GameObject.FindObjectOfType<MissionSystem>();
        GPSAYARLA();
        Invoke("yerlestir", 0.3f);
        Invoke("navmeshrestart", count);
        navmeshzero();

    }
    public void navmeshzero()
    {
        navmeshzerobool = true;
        Invoke("navmeshzeroclose", 3f);

    }
    public void navmeshzeroclose()
    {
        navmeshzerobool = false;
        Invoke("navmeshzero", 20f);
    }
    public void navmeshrestart()
    {
        navmesh.enabled = false;
        Invoke("navmeshac", 0.5f);
    }
    public void yerlestir()
    {
        navmesh = GameObject.FindWithTag("navigator").GetComponent<NavMeshAgent>();
        bitis = GameObject.FindWithTag("Finish");
        Distance = GameObject.FindWithTag("disttex").GetComponent<Text>();
        cizgiacik = true;
        mapcizgikapat();


    }
    public void navmeshac()
    {
        navmesh.enabled = false;
        navmesh.enabled = true;
        Invoke("navmeshrestart", count);
        GPSAYARLA();
        navmeshzero();
    }
    public void mapcizgikapat()
    {
        if (cizgiacik == true)
        {
            gameObject.layer = 0;
            cizgiacik = false;
        }
    }
    public void mapcizgiac()
    {
        if (cizgiacik == false)
        {
            gameObject.layer = 10;
            cizgiacik = true;
        }
    }
    public void GPSAYARLA()
    {
    
        if (bitis != null)
        {
            navmesh.SetDestination(bitis.transform.position);
            if (navmesh.path.corners.Length < 2)
            {
                return;
            }
            for (int i = 1; i < navmesh.path.corners.Length; i++)
            {

                Vector3 pointpos = new Vector3(navmesh.path.corners[i].x, -5, navmesh.path.corners[i].z);
                gameObject.GetComponent<LineRenderer>().SetPosition(i, pointpos);
            }
        }
        Invoke("GPSAYARLA", 2f);
        }
    void FixedUpdate()
    {
        if (navmeshzerobool == true)
        {
            navmesh.transform.localPosition = new Vector3(0, 0, 0);
            navmesh.transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        if (cizgiacik == false)
        {
            Distance.text = "GO TARGET!";
        }
        else
        {
            Distance.text = Vector3.Distance(navmesh.transform.position, bitis.transform.position).ToString("F0") + " m";
        }
        if (missioncode.trailerattached == true)
        {
            mapcizgiac();
        }
        else
        {
            mapcizgikapat();
        }
        count -= Time.deltaTime;
        if(count <= 0){
            navmesh.enabled = false;
            navmesh.enabled = true;
            count = navmeshreset;
        }


        else
        {
            if (navmesh != null)
            {
                if (bitis != null)
                {

            
                    gameObject.GetComponent<LineRenderer>().SetPosition(0, new Vector3(navmesh.transform.position.x, -6, navmesh.transform.position.z));
                    gameObject.GetComponent<LineRenderer>().positionCount = navmesh.path.corners.Length;
                    navmesh.SetDestination(bitis.transform.position);
                    gameObject.GetComponent<LineRenderer>().widthMultiplier = 30f;
                }
            }
        }
    }
    }

