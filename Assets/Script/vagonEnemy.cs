using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vagonEnemy : MonoBehaviour
{
    public Transform shotCtrl;
    public float cd;
    public GameObject bullet;
    void Start()
    {
        StartCoroutine(Disparo());
    }

    
    IEnumerator Disparo()
    {
        Instantiate(bullet, transform.position, transform.rotation);
        yield return new WaitForSeconds(cd);
    }
}
