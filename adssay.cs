using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class adssay : MonoBehaviour
{
    // Start is called before the first frame update
    public MissionSystem missioncode;
    public Text saytex;
    void Start()
    {
        missioncode = FindObjectOfType<MissionSystem>();  
    }
    private void OnEnable()
    {

        Invoke("say2", 1f);
        saytex.text = "3";
    }
    public void say2()
    {
  
        saytex.text = "2";
        Invoke("say1", 1f);
    }
    public void say1()
    {
        saytex.text = "1";
        Invoke("say0", 1f);
    }
    public void say0()
    {
        saytex.text = "0";
        missioncode.geciscek();
        gameObject.SetActive(false);
    }
    // Update is called once per frame

}
