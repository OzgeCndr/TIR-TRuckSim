using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class hedef : MonoBehaviour
{
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("playersec", 0.5f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
     gameObject.transform.position = new Vector3(Player.transform.position.x, -5, Player.transform.position.z);
        gameObject.transform.rotation = Quaternion.Euler(90f,Player.transform.eulerAngles.y,0f);
    }
    public void playersec()
    {
        Player = GameObject.FindWithTag("Player");
    }
}
