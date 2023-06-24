using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vagonEnemy : MonoBehaviour
{
    public Transform shotCtrl;
    public float cd;
    public GameObject bullet;
    bool isShooting;

    private void Update()
    {
        if(!isShooting)
        {
            StartCoroutine(Disparo());
        }
    }
    public void ActivarDisparo()
    {
        isShooting = false;
    }
    

    IEnumerator Disparo()
    {
        isShooting = true;
        while(true)
        {
            Instantiate(bullet, shotCtrl.transform.position, shotCtrl.transform.rotation);
            yield return new WaitForSeconds(cd);
        }
       
    }
}
