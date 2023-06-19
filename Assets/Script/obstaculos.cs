using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaculos : MonoBehaviour
{
    public int life;
    

    
    void Update()
    {
        if(life <= 0)
        {
            Destroy(gameObject);
        }
    }
}
