using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [Header("Disparo")]
    public KeyCode gatillo;
    public GameObject bullet;
    bool canShoot;
    public GameObject brazo;

    [Header("Tiempo")]
    public float TiempoCd;
    float timer;
    bool canWait;
    private void Start()
    {
        brazo.SetActive(false);
        timer = 0;
        canWait = false;
        canShoot = true;
    }
    private void Update()
    {
        if(canShoot)
        {
            if (Input.GetKeyDown(gatillo))
            {
                Disparar();
                canShoot = false;
                
            }
        }
        
        if(canWait)
        {
            brazo.SetActive(false);
           
            if(timer>= TiempoCd)
            {
                canShoot = true;
                canWait = false;

            }
            else
            {
                timer += Time.deltaTime;
            }
        }

        
    }
    public void Disparar()
    {
        brazo.SetActive(true);
        Instantiate(bullet, transform.position, transform.rotation);
        timer = 0;
        canWait = true;
    }
        
}
