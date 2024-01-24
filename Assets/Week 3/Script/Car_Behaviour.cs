using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Car_Behaviour : MonoBehaviour
{
    float accelaration;
    float steering;
    //I made the max speed smaller since I made the car smaller and it seemed to accelerate faster. 
    public float maxSpeed = 350; 
    public float forwardSpeed = 500;
    public float steeringSpeed = 100;
    Rigidbody2D rigibody; 
    void Start()
    {
        rigibody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        accelaration = Input.GetAxis("Vertical");
        steering = Input.GetAxis("Horizontal"); 
    }

    private void FixedUpdate()
    {
        rigibody.AddTorque(steering * -steeringSpeed * Time.deltaTime);
        Vector2 force = transform.up * accelaration * forwardSpeed * Time.deltaTime;
        if (rigibody.velocity.magnitude < maxSpeed)
        { 
        rigibody.AddForce(force);
    }
    }
}
