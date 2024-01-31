using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireShootScript : MonoBehaviour
{
    Rigidbody2D rigibody;
    float speed = 15.5f;
    public GameObject obstacle;
    // Start is called before the first frame update
    void Start()
    {
        rigibody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }
    private void FixedUpdate()
    {
        Vector2 direction = Vector2.up * speed * Time.deltaTime;
        rigibody.MovePosition(rigibody.position + direction);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);

        GameObject collidedObject = collision.gameObject;

        if (collidedObject.name == "Obstacle")
        {
            collidedObject.SetActive(false);
        }
    }
}
