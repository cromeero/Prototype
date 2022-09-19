using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  public float speed = 20; 
  public float  turnSpeed = 100; 
  public float horizontalInput;
  public float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
      
      horizontalInput = Input.GetAxis("Horizontal");
      forwardInput = Input.GetAxis("Vertical"); 
        //Move the vechicle forward
      transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
      // Roates the car based on horizontal input
      transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime); 
     

    }
}
