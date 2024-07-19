using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noticecode : MonoBehaviour
{
    public float count;
    public GameObject[] noticegroups;

    // Start is called before the first frame update
    void Start()
    {
        count = 10f;


    }
    private void OnEnable()
    {
        count = 10f;
    }
    private void OnDisable()
    {
        count = 10f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        count -= Time.deltaTime;
        if (count <= 0)
        {
            count = 10f;
            for (int i = 0; i < noticegroups.Length; i++)
            {
                noticegroups[i].SetActive(false);
            }
            gameObject.SetActive(false);

       
        }
    }
}
