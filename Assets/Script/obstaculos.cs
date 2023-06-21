using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaculos : MonoBehaviour
{
    public int life;

    public bool isDestruct;
    
    void Update()
    {
        if (life <= 0)
        {
            Destroy(gameObject);
        }

        if(transform.position.y <= -15)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(isDestruct)
        {
            if (collision.gameObject.CompareTag("Bullet"))
            {
                life -= collision.gameObject.GetComponent<Bullets>().damage;
            }
        }
    }
}
