﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    private float laserSpeed = 600;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(RemoveLaser());
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * laserSpeed);
    }



    IEnumerator RemoveLaser()
    {
        yield return new WaitForSeconds(3);
        Destroy(gameObject);
    }
   
}
