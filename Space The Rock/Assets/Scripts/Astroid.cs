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
        transform.Rotate(new Vector3((Random.Range(1, 360)), (Random.Range(1, 360)), (Random.Range(1, 360))) * Time.deltaTime);
    }
    

    private void OnCollisionEnter(Collision other) {
        Destroy(other.gameObject);

        
    }
   
}