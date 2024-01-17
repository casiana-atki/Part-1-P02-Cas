using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    Rigidbody2D rigibody;
    float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        rigibody = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }
    private void FixedUpdate()
    {
        Vector2 direction = new Vector2(speed * Time.deltaTime, 0);
        rigibody.MovePosition(rigibody.position + direction); 
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("missile collision");
        Destroy(gameObject);
    }
}
