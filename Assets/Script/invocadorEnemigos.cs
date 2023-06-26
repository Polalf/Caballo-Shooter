using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invocadorEnemigos : MonoBehaviour
{
    [SerializeField] float minCd, maxCd;
    float cdTren, cdGun;
    [SerializeField] GameObject tren, gunfighter;
    public bool canTren, canGun;
    void Start()
    {
        //GUNFIGTHER
        canGun = true;
        cdGun = Random.Range(minCd, maxCd);
        StartCoroutine(ActivarGun());
        //TREN
        canTren = true;
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
        canGun = false;
        yield return new WaitForSeconds(cdGun);
        gunfighter.GetComponent<Enemy>().ActivarGunfighter();

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
        canTren = false;
        yield return new WaitForSeconds(cdTren);
        while(canAct)
        {
            tren.GetComponent<train>().Activar();
            canAct = false;
            break;
        }
    }
}
