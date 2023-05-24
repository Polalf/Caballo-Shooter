using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridMove : MonoBehaviour
{
    public float speed;
    

    
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            MoveGrid(Vector3.up);
        }
        if(Input.GetKey(KeyCode.S))
        {
            MoveGrid(Vector3.down);
        }
        if(Input.GetKey(KeyCode.A))
        {
            MoveGrid(Vector3.left);
        }
        if(Input.GetKey(KeyCode.D))
        {
            MoveGrid(Vector3.right);
        }
    }
    void MoveGrid(Vector3 dir)
    {
        transform.Translate(dir * speed * Time.deltaTime);
    }
}
