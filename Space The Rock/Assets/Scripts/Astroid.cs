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
    public GameManager gameManager;
    public GameManager deathcommand;
    public int astroidPoints = 10;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        
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
             AstroidScore();
            Destroy(other.gameObject);
            Destroy(gameObject);
            
            // end game
        } else if(other.gameObject.tag == "Player"){
            Destroy(other.gameObject);
            gameManager.GameOver();
            Debug.Log("bruh");
        }
 // astroid destroyed zichzelf met collision omdat spawned op zelfde positie   
    }

   //turn big astroidin 2 medium
    public void BigAstroid(){
        Debug.Log("xDGROOT");
        AstroidScore(); // add score
        Instantiate(mediumAstroid, gameObject.transform.position, gameObject.transform.rotation);
        Instantiate(mediumAstroid, gameObject.transform.position, gameObject.transform.rotation);
    }

    // turn medium astroid into 2 small
    
    public void MedAstroid(){
        Debug.Log("MEDIUM BRUH");
        AstroidScore(); // add score
        Instantiate(smallAstroid, gameObject.transform.position, gameObject.transform.rotation);
        Instantiate(smallAstroid, gameObject.transform.position, gameObject.transform.rotation);
    }

    // max speed
    void FixedUpdate() {
        if(rb.velocity.magnitude > maxSpeed){
            rb.velocity = Vector3.ClampMagnitude(rb.velocity, maxSpeed);
        }
    }

    //add points to score
    public void AstroidScore(){
        gameManager.UpdateScore(astroidPoints);
    }

}