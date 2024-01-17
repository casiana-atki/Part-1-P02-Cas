using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody2D rigibody;
    public float force; 
    Vector2 direction; 
    // Start is called before the first frame update
    void Start()
    {
        rigibody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        direction.x = Input.GetAxis("Horizontal");
        direction.y = Input.GetAxis("Vertical"); 
    }

    private void FixedUpdate()
    {
        rigibody.AddForce(direction * force * Time.deltaTime) ; 
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("player hit something");
    }
}