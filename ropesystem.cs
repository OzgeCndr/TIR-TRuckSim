using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ropesystem : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] ropeparts;
    public LineRenderer linecode;
    public Vector3[] ropevectors;
    public bool active;
    public GameObject[] depo;
    public GameObject kafabaslangic;
    public GameObject selectdepo;

    
   
    void Start()
    {
        Invoke("depocek", 1f);
        linecode.positionCount = ropeparts.Length;
        ropevectors = new Vector3[ropeparts.Length];


    }
    private void OnEnable()
    {
        Invoke("depocek", 1f);
    }
    public void depocek()
    {
        depo[0] = GameObject.FindWithTag("fuelcube");
        depo[1] = GameObject.FindWithTag("fuelcube2");

     
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float distance1 = Vector3.Distance(ropeparts[0].transform.position, depo[0].transform.position);
        float distance2 = Vector3.Distance(ropeparts[0].transform.position, depo[1].transform.position);
        float yakinolan = Mathf.Min(distance1, distance2);
        if (yakinolan == distance1)
        {
            selectdepo = depo[0];
        }
        if (yakinolan == distance2)
        {
            selectdepo = depo[1];
        }
        if (active == true)
        {
            ropeparts[ropeparts.Length - 1].transform.position = Vector3.Lerp(ropeparts[ropeparts.Length - 1].transform.position, selectdepo.transform.position,Time.deltaTime*5);
        }
        else
        {
            ropeparts[ropeparts.Length - 1].transform.position = Vector3.Lerp(ropeparts[ropeparts.Length - 1].transform.position, kafabaslangic.transform.position, Time.deltaTime*10);
        }
        for (int i = 0; i < ropeparts.Length; i++)
        {
            ropevectors[i] = ropeparts[i].transform.position;
            linecode.SetPosition(i, ropevectors[i]);
        }

    }
}
