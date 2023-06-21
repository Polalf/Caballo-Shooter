using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    public float speed;
    public int damage;
    [SerializeField] float tiempoDestruct;
    [SerializeField] bool autodestruir;

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
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
