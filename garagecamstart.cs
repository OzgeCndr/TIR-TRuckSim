using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class garagecamstart : MonoBehaviour
{
    public RCC_Camera cameracode;
    // Start is called before the first frame update
    void Awake()
    {
        cameracode.TPSStartRotation = new Vector3(-15f, 195f, 0f);


    }
    public void Start()
    {
        Invoke("cek", 1f);
    }
    public void cek()
    {
        cameracode.TPSStartRotation = new Vector3(-15f, 195f, 0f);
        cameracode.ResetCamera();

    }
    // Update is called once per frame
    void FixedUpdate()
    {
        cameracode.TPSStartRotation= new Vector3(-15f, 195f, 0f);

    }
}
