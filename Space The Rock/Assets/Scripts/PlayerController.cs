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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        //fly code
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
        transform.Translate(Vector3.forward * Time.deltaTime * movementSpeed * verticalInput);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(laser, firePoint.transform.position, firePoint.transform.rotation);
            Instantiate(laser, firePoint2.transform.position, firePoint2.transform.rotation);
        }
    }
}
