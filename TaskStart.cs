using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskStart : MonoBehaviour
{
    public MenuCanvas canvascode;
    public MissionSystem missioncode;
    public int SetSpawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        canvascode = FindObjectOfType<MenuCanvas>();
        missioncode = FindObjectOfType<MissionSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.name == "carcol")
        {
            missioncode.spawnpoint = SetSpawnPoint;
            missioncode.trailerspawnselect();
            canvascode.rcccanvas.SetActive(false);
            canvascode.pausecanvas.SetActive(false);
            canvascode.finishcanvas.SetActive(false);
            canvascode.missioncanvas.SetActive(true);
            canvascode.blurcode.enabled = true;
            canvascode.Player.GetComponent<Rigidbody>().constraints= RigidbodyConstraints.FreezePosition;
            

        }
    }

}
