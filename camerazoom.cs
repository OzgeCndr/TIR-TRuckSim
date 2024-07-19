using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerazoom : MonoBehaviour
{
    public RCC_MobileUIDrag dragcode;
    public RCC_Camera CAMCODE;
    public float maxzoom;
    public float minzoom;
    private float oneshot= 0;
    private float twoshot = 0;
    private float shotnumber = 0f;
    public float startminfov;
    private float startmaxfovvalue;
    public bool gaspush;
    public bool brakepush;
    public bool handbrakepush;
    public bool leftpush;
    public bool rightpsuh;
    public bool oneshotbool=false;

    // Start is called before the first frame update
    void Start()
    {
        startminfov = CAMCODE.TPSMinimumFOV;
        startmaxfovvalue = CAMCODE.TPSMaximumFOV - CAMCODE.TPSMinimumFOV;
    }
    public void gaspushac()
    {
        gaspush = true;
    }
    public void gaspushkapa()
    {
        gaspush = false;
    }
    public void brakepushac()
    {
        brakepush = true;
    }
    public void brakepushkapa()
    {
        brakepush = false;
    }
    public void handbrakepushac()
    {
        handbrakepush = true;
    }
    public void handbrakepushkapa()
    {
        handbrakepush = false;
    }
    public void leftpushac()
    {
        leftpush = true;
    }
    public void leftpushkapa()
    {
        leftpush = false;
    }
    public void rightpushac()
    {
        rightpsuh = true;
    }
    public void rightpushkapa()
    {
        rightpsuh = false;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (dragcode.isPressing == true & gaspush==false & brakepush==false & handbrakepush==false & leftpush==false & rightpsuh==false)
        {
            if (Input.touchCount == 2)
            {
                Touch touch1 = Input.GetTouch(0);
                Touch touch2 = Input.GetTouch(1);

     
                if (touch1.phase == TouchPhase.Moved && touch2.phase == TouchPhase.Moved)
                {
                    if (oneshotbool == false)
                    {
                        oneshot = Vector2.Distance(touch1.position, touch2.position);
                        oneshotbool = true;
                    }
                    twoshot = Vector2.Distance(touch1.position, touch2.position);
                    shotnumber = (twoshot - oneshot)/250f;

                    CAMCODE.TPSMinimumFOV -= shotnumber;
                    CAMCODE.TPSMaximumFOV = CAMCODE.TPSMinimumFOV + startmaxfovvalue;
                    if (CAMCODE.TPSMinimumFOV > startminfov + minzoom)
                    {
                        CAMCODE.TPSMinimumFOV = startminfov + minzoom;
                    }
                    if (CAMCODE.TPSMinimumFOV < startminfov - maxzoom)
                    {
                        CAMCODE.TPSMinimumFOV = startminfov - maxzoom;
                    }

                }
                if (touch1.phase == TouchPhase.Ended || touch2.phase == TouchPhase.Ended)
                {
                    oneshotbool = false;
                    shotnumber = 0f;

                }
                if (touch1.phase == TouchPhase.Ended)
                {
                    oneshotbool = false;
                    shotnumber = 0f;
                }
                }
        }
        else
        {
            oneshotbool = false;
        }
    }
}

    

