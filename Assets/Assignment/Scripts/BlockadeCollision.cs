using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    public GameObject block;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == block)
        {
            if (block.activeInHierarchy)
            {
                block.SetActive(false);
            }
            else
            {
                block.SetActive(true);
            }
        }
    }
}
