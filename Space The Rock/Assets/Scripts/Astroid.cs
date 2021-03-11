using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Astroid : MonoBehaviour {

    // Use this for initialization
    private Rigidbody rb;
    private float spinSpeed = 10f;
    
    void Start()
    {
        

    }

    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 300) * Time.deltaTime);
    }


    void OnCOllisionEnter(Collision collision)
}