using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridMove : MonoBehaviour
{
    public float speed;
    bool isMoving;
    Vector3 oriPos, targetPos;
    float timeToMove = 0.2f;
   

    private void Update()
    {
        if(transform.position.y != 6)
        {
            if (Input.GetKeyDown(KeyCode.W) && !isMoving)
            {
                StartCoroutine(MovePlayer(Vector3.up + new Vector3(0, speed)));
            }
        }
        if(transform.position.y != -9)
        {
            if (Input.GetKeyDown(KeyCode.S) && !isMoving)
            {
                StartCoroutine(MovePlayer(Vector3.down + new Vector3(0, -speed)));
            }
        }
        if(transform.position.x != -6)
        {
            if (Input.GetKeyDown(KeyCode.A) && !isMoving)
            {
                StartCoroutine(MovePlayer(Vector3.left + new Vector3(-speed, 0)));
            }
        }
        if (transform.position.x != 6)
        {
            if (Input.GetKeyDown(KeyCode.D) && !isMoving)
            {
                StartCoroutine(MovePlayer(Vector3.right + new Vector3(speed, 0)));
            }
        }

            
    }

    IEnumerator MovePlayer(Vector3 dir)
    {
        isMoving = true;

        float elapsedTime = 0;

        oriPos = transform.position;
        targetPos = oriPos + dir;

        while(elapsedTime < timeToMove)
        {
            transform.position = Vector3.Lerp(oriPos, targetPos, (elapsedTime / timeToMove));
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        transform.position = targetPos;
        isMoving = false;
    }

}
