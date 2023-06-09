using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject[] obstaculos;
    public float tiempoSpawn;
    float timer;

    private void Start()
    {
        
    }


    void Update()
    {
       if(timer >= tiempoSpawn)
       {
            Spawnear();
       }
    }

    void Spawnear()
    {
        int x = Random.Range(0, obstaculos.Length);
        Instantiate(obstaculos[x], transform.position, transform.rotation);
        timer = 0;
    }
}
