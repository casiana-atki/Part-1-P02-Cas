using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlagueDoctorMovement : MonoBehaviour
{
    public Rigidbody2D rigibody;
    public float speed;
    public GameObject prefab;
    public Transform spawnPoint;
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

        spawnPoint.position = transform.position;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, spawnPoint.position, transform.rotation);
        }
    }
    private void FixedUpdate()
    {
        rigibody.AddForce(direction * speed * Time.deltaTime);
    }
}
