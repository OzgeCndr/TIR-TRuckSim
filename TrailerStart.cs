using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailerStart : MonoBehaviour
{
    public RCC_TruckTrailer trailercode;
    public GameObject leds;
    // Start is called before the first frame update
    void Start()
    {
        trailercode = gameObject.GetComponent<RCC_TruckTrailer>();
        Invoke("calistir", 3f);
    }
    public void calistir()
    {
        gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (trailercode.attached == true)
        {
            gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            leds.SetActive(false);
            Destroy(this);
        }
    }
}
