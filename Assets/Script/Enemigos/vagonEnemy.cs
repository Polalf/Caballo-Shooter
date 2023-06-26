using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vagonEnemy : MonoBehaviour
{
    [SerializeField] int life = 50;
    int currentLife;
    [SerializeField] Transform shotCtrl;
    [SerializeField] float minCd, maxCd;
    float cd;
    [SerializeField] GameObject bullet;

    private void Start()
    {
        currentLife = life;
    }
    private void Update()
    {
        if(currentLife<=0)
        {
            gameObject.GetComponentInParent<vagon>().contador--;
            gameObject.SetActive(false);
            ResetearValores();
        }
    }
    public void ResetearValores()
    {
        currentLife = life;
        //gameObject.GetComponentInParent<vagon>().contador++;
    }
    public void ActivarDisparo()
    {
        cd = Random.Range(minCd, maxCd);
        StartCoroutine(Disparo());
    }
    

    IEnumerator Disparo()
    {
        while(true)
        {
            yield return new WaitForSeconds(cd);
            Instantiate(bullet, shotCtrl.transform.position, shotCtrl.transform.rotation);
            cd = Random.Range(minCd, maxCd);
        }
       
    }
}
