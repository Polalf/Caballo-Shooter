using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Header("Control de Disparo")]
    public Transform shotCtrl;
    [SerializeField] float cd;
    public GameObject bullet;
    

    [Header("Stats")]
    public float life;

    [Header("Persecucion")]
    public Transform target;

    private void Start()
    {
        
    }
    void Update()
    {

        if(life <=0)
        {

        }
        StartCoroutine(Disparo());
    }

    IEnumerator Disparo()
    {
        Instantiate(bullet, shotCtrl.transform.position, shotCtrl.transform.rotation);
        yield return new WaitForSeconds(cd);
    }
    
}
