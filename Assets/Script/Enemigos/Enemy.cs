using System.Collections;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] int puntaje;
    [Header("Movimiento")]
    [SerializeField] float offset;
    [SerializeField] Transform target;

    [Header("Vida")]
    [SerializeField] int life;
    int currentLife;
    bool isDead;
    [SerializeField] float minTiempoFuera, maxTiempoFuera;
    float tiempoFuera;

    [Header("Ataque")]
    [SerializeField] GameObject bullet;
    [SerializeField] float minCd, maxCd;
    float cd;
    [SerializeField] Transform shotCtrl;
   
    
    void Start()
    {
        ActivarEnemy();
        
        currentLife = life;
    }


    void Update()
    {
        //MOVIMIENTO
        transform.position = new Vector3(offset, target.position.y);
        
        //VIDA
        if(!isDead)
        {
            if (currentLife <= 0)
            {
                StopCoroutine(Disparo());
                StartCoroutine(TiempoFuera());
                isDead = true;
            }
        }
        
    }

    //FUNCIONES
    void ActivarEnemy()
    {
        currentLife = life;
        isDead = false;
        cd = Random.Range(minCd, maxCd);
        StartCoroutine(Disparo());
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            currentLife -= collision.gameObject.GetComponent<Bullets>().damage;
        }
    }

    //COROUTINAS

    IEnumerator Disparo()
    {
        while(true)
        {
            yield return new WaitForSeconds(cd);
            Instantiate(bullet, shotCtrl.position, shotCtrl.rotation);
            cd = Random.Range(minCd, maxCd);
        }
    }

    IEnumerator TiempoFuera()
    {

        tiempoFuera = Random.Range(minTiempoFuera, maxTiempoFuera);
        target.gameObject.GetComponent<ScoreControl>().score += puntaje;
        for (float i = 0; i < tiempoFuera; i += Time.deltaTime)
        {
            yield return null;
        }
        ActivarEnemy();
        
    }

    
}
