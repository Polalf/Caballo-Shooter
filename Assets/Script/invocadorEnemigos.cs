using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invocadorEnemigos : MonoBehaviour
{
    [SerializeField] float minCd, maxCd;
    float cdTren, cdGun;
    [SerializeField] GameObject tren, gunfighter;
    void Start()
    {
        //GUNFIGTHER
       
        cdGun = Random.Range(minCd, maxCd);
        StartCoroutine(ActivarGun());
        //TREN
       
        cdTren = Random.Range(minCd, maxCd);
        StartCoroutine(ActivarTren());

    }

    //RUTINA GUNFIGHTER
    public void ActivarRutinaGun()
    {
        cdGun = Random.Range(minCd, maxCd);
        StartCoroutine(ActivarGun());
    }
    IEnumerator ActivarGun()
    {
        yield return new WaitForSeconds(cdGun);
    }

    //RUTINA TREN
    public void ActivarRutinaTren()
    {
        cdTren = Random.Range(minCd, maxCd);
        StartCoroutine(ActivarTren());
    }
    IEnumerator ActivarTren()
    {
        bool canAct = true;
        
        yield return new WaitForSeconds(cdTren);
        while(canAct)
        {
            tren.GetComponent<train>().Activar();
            canAct = false;
            break;
        }
    }
}
