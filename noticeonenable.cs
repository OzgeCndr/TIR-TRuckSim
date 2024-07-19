using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noticeonenable : MonoBehaviour
{
    public GameObject[] kapatilcak;
    // Start is called before the first frame update
    void Start()
    {

    }
    private void OnEnable()
    {
        for (int i = 0; i < kapatilcak.Length; i++)
        {
            kapatilcak[i].SetActive(false);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
