using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    public float speed;
    [SerializeField] public float tiempoDestruct;
    public bool autodestruir;
    void Start()
    {
        if(autodestruir)
        {
            Destroy(gameObject, tiempoDestruct);
        }
    }
       

   
    void Update()
    {
        transform.position += transform.up * speed * Time.deltaTime;
    }
}
