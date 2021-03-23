using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    private float verticalInput;
    private float movementSpeed = 500;
    private float turnSpeed = 100;
    public GameObject laser;
    public GameObject firePoint;
    public GameObject firePoint2;
    private bool onCooldown = false;
    private float cooldownTime = 0.2f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //get arrowkeys or wasd input
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        //make ship rotate
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);

        //make ship move forward andbackwards
        transform.Translate(Vector3.forward * Time.deltaTime * movementSpeed * verticalInput);

        //get space bar input
    if (Input.GetButton("Jump") && onCooldown == false)
        {
            // spawn laser at firepoint location and rotation
            Instantiate(laser, firePoint.transform.position, firePoint.transform.rotation);
            
            // start firerate cooldown
            StartCoroutine(FireCooldown());
        }
    }

    // firerate cooldown
    IEnumerator FireCooldown()
    {
        onCooldown = true;
        yield return new WaitForSeconds(cooldownTime);
        onCooldown = false;
    }
}
