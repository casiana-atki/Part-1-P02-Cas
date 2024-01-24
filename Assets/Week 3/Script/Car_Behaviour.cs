using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car_Behaviour : MonoBehaviour
{
    float accelaration;
    float steering;
    public float forwardSpeed = 500;
    public float steeringSpeed = 100;
    Rigidbody2D rigidbody; 
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        accelaration = Input.GetAxis("Vertical");
        steering = Input.GetAxis("Horizontal"); 
    }

    private void FixedUpdate()
    {
        rigidbody.AddTorque(steering * -steeringSpeed * Time.deltaTime);
        Vector2 force = transform.up * accelaration * forwardSpeed * Time.deltaTime; 
        rigidbody.AddForce(force);
    }
}
