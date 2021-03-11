using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Astroid : MonoBehaviour {

    // Use this for initialization
    private Rigidbody rb;
    private float spinSpeed = 10f;
    
    void Start()
    {
        for (int i = 1; i < 360; i++)
        {
            gameObject.transform.rotation = Quaternion.Euler(i, i, 0);
            System.Threading.Thread.Sleep(5000);
        }

    }

    void Update()
    {
        
    }
}