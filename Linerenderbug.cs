using UnityEngine;

public class Linerenderbug : MonoBehaviour
{
    public GameObject linerenderprefab;
    public Vector3 startlinerenderposition;
    public GameObject selectlinerender;
    public Vector3[] lindevector;
    public MissionSystem missioncode;
    public float gerisay;
    // Start is called before the first frame update
    void Start()
    {
        missioncode = FindObjectOfType<MissionSystem>();
        selectlinerender = GameObject.FindWithTag("linerenderer");
        startlinerenderposition = selectlinerender.transform.position;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (missioncode.missionactive == true & selectlinerender.GetComponent<LineRenderer>().positionCount > 2)
        {
            lindevector[0] = selectlinerender.GetComponent<LineRenderer>().GetPosition(1);
            lindevector[1] = selectlinerender.GetComponent<LineRenderer>().GetPosition(2);
            if (lindevector[0].x == 0 & lindevector[1].x == 0 & missioncode.trailerattached == true )
            {
                gerisay -= Time.deltaTime;
            }
            else
            {
                if (gerisay != 5)
                {
                    gerisay = 5;
                }
            }
           if(gerisay <= 0)
            {
                Destroy(selectlinerender);
                selectlinerender= Instantiate(linerenderprefab);
                selectlinerender.transform.SetParent(gameObject.transform);
                selectlinerender.transform.position = startlinerenderposition;
                gerisay = 5f;
            }
        }
    }
}
