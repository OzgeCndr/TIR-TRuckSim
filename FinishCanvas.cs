using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishCanvas : MonoBehaviour
{

    public int money;
    public Text moneytex;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnEnable()
    {
        PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") + money);
        moneytex.text = "+" + money + " $";
    }
    public void moneyx2()
    {
        PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") + money);
        moneytex.text = "+" + money*2 + " $";
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
