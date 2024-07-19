using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlakaYaz : MonoBehaviour
{
    public TMP_Text plaka;
    // Start is called before the first frame update
    void Start()
    {
        plakakontrol();
    }
    public void plakakontrol()
    {
        plaka.text = PlayerPrefs.GetString("plaka");
        Invoke("plakakontrol", 1f);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
