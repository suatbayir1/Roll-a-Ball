using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraKontrol : MonoBehaviour
{
    public GameObject top;
    Vector3 aradakiMesafe;

    void Start()
    {
        aradakiMesafe = transform.position - top.transform.position; // kamera ile top arasındaki mesafe
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = top.transform.position + aradakiMesafe; // kamerayı topdan mesafe kadar geride tut
    }
}
