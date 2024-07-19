using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public MenuCanvas canvascode;
    public GameObject JobTriggers;
    public MissionSystem missioncode;
    // Start is called before the first frame update
    void Start()
    {
        canvascode = Object.FindObjectOfType<MenuCanvas>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.name == "carcol")
        {

            canvascode.rcccanvas.SetActive(false);
            canvascode.pausecanvas.SetActive(false);
            canvascode.finishcanvas.SetActive(true);
            canvascode.blurcode.enabled = true;
            canvascode.Player.GetComponent<Rigidbody>().constraints= RigidbodyConstraints.FreezePosition;
            missioncode.SelectTrailer.GetComponent<RCC_TruckTrailer>().DetachTrailer();
            missioncode.SelectTrailer.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;
            Invoke("cagir", 1);

        }
    }
    public void cagir()
    {
        missioncode.FinishObject.SetActive(false);
        JobTriggers.SetActive(true);
        Destroy(missioncode.SelectTrailer);
        canvascode.Player.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        canvascode.Player.transform.position = gameObject.transform.position;
        canvascode.Player.transform.rotation = gameObject.transform.rotation;
        missioncode.missionactive = false;
    }
}
