using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Astroid : MonoBehaviour {

    // Use this for initialization
    private Rigidbody rb;
    private float spinSpeed = 10f;
    private float maxSpeed = 100f;
    public GameObject mediumAstroid;
    public GameObject smallAstroid;
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    void Update()
    {
        //spin in random direction
        transform.Rotate(new Vector3((Random.Range(1, 360)), (Random.Range(1, 360)), (Random.Range(1, 360))) * Time.deltaTime);
    
    }
    

    // kill space ship on impact
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "Laser"){
            
            // if laser hit big rock destroy and start BigAstroid
            if(gameObject.tag == "Big"){
                BigAstroid();              
            // if laser hit medium rock destroy and start MedAstroid
            } else if(gameObject.tag == "Med"){
                MedAstroid();             
            }
            Destroy(other.gameObject);
            Destroy(gameObject);
        } else if(other.gameObject.tag == "player"){
            Destroy(gameObject);
        }
 // astroid destroyed zichzelf met collision omdat spawned op zelfde positie   
    }

   
    private void BigAstroid(){
        Debug.Log("xDGROOT");
        Instantiate(mediumAstroid, gameObject.transform.position, gameObject.transform.rotation);
        Instantiate(mediumAstroid, gameObject.transform.position, gameObject.transform.rotation);
    }

    // turn medium astroid into 2 small
    private void MedAstroid(){
        Debug.Log("MEDIUM BRUH");
        Instantiate(smallAstroid, gameObject.transform.position, gameObject.transform.rotation);
        Instantiate(smallAstroid, gameObject.transform.position, gameObject.transform.rotation);
    }


    void FixedUpdate() {
        if(rb.velocity.magnitude > maxSpeed){
            rb.velocity = Vector3.ClampMagnitude(rb.velocity, maxSpeed);
        }
    }

}