using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Astroid : MonoBehaviour {

    // Use this for initialization
    private Rigidbody rb;
    private float spinSpeed = 10f;
    public GameObject mediumAstroid;
    public GameObject smallAstroid;
    void Start()
    {
        

    }

    void Update()
    {
        //spin in random direction
        transform.Rotate(new Vector3((Random.Range(1, 360)), (Random.Range(1, 360)), (Random.Range(1, 360))) * Time.deltaTime);
    
    }
    

    // kill space ship on impact
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "Laser"){
            Destroy(gameObject);
            // if laser hit big rock destroy and start BigAstroid
            if(gameObject.tag == "Big"){
                Destroy(other.gameObject);
                BigAstroid();
                Destroy(gameObject);
               
            // if laser hit medium rock destroy and start MedAstroid
            } else if(gameObject.tag == "Med"){
                Destroy(other.gameObject);
                MedAstroid();
                Destroy(gameObject);
                
            } else Destroy(gameObject);

        } else Destroy(other.gameObject);   
    
    }

    // turn big astroid into 2 medium
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

}