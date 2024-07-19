using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    public Transform target;

    private void Start()
    {
        if (target == null)
        {
            target = GameObject.FindWithTag("MainCamera").transform;
        }
    }
    void FixedUpdate()
    {
        Vector3 direction = target.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(direction);
        transform.rotation = rotation;
    }
}