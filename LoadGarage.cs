using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadGarage : MonoBehaviour
{
    public SceneLoadManagers levelcode;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetString("clicklevel", "Garage");

        levelcode.Levelsec();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
