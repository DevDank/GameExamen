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
    

// kill space ship on impact
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "Laser"){
            Destroy(gameObject);
        } else Destroy(other.gameObject);


        
    }
   
}