using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    [SerializeField] float speed;
    Vector3 oriPos, targetPos;

    private void Start()
    {
        oriPos = transform.position;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            targetPos += new Vector3(0, speed);
            MoverPlayer();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
        }
    }
    
    void MoverPlayer()
    {
        transform.position += targetPos * Time.deltaTime;
        oriPos = targetPos;
       
    }


}
