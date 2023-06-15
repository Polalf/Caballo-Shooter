using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridMove : MonoBehaviour
{
    //public float speed;
    bool isMoving;
    Vector3 oriPos, targetPos;
    public Sfloat timeToMove = 0.2f;


    private void Update()
    {
        
        if(Input.GetKey(KeyCode.W) && !isMoving)
        {
            StartCoroutine(MovePlayer(Vector3.up));
        }
        if(Input.GetKey(KeyCode.S) && !isMoving)
        {
            StartCoroutine(MovePlayer(Vector3.down));
        }
        if(Input.GetKey(KeyCode.A) && !isMoving)
        {
            StartCoroutine(MovePlayer(Vector3.left));
        }
        if(Input.GetKey(KeyCode.D) && !isMoving)
        {
            StartCoroutine(MovePlayer(Vector3.right));
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
