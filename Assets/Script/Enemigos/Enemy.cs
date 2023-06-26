using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Header("Control de Disparo")]
    public Transform shotCtrl;
    [SerializeField] float minCd, maxCd;
    float cd;
    public GameObject bullet;


    [Header("Stats")]
    public float life;
    bool isLife;
    bool canMove;

    [Header("Persecucion")]
    public Transform player;
    [SerializeField] float offset;
    [SerializeField] Transform puntoA, target;

    void Update()
    {
        if (canMove)
        {
            transform.position += target.position * Time.deltaTime;
        }
        if (transform.position.x <= offset)
        {
            canMove = false;
            isLife = true;
        }
        if (isLife)
        {
            transform.position = new Vector3(offset, player.position.y);
            if (life <= 0)
            {
                isLife = false;
                canMove = true;
                DetenerGunfighter();
            }
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            life -= collision.gameObject.GetComponent<Bullets>().damage;
        }
    }
    public void ActivarGunfighter()
    {
        life = 100;
        canMove = true;
        StartCoroutine(Disparo());
        target.position = new Vector3(offset, 0);
    }
    public void DetenerGunfighter()
    { 
        target.position = new Vector3(puntoA.position.x, 0);
        canMove = true;
        if (transform.position.x <= puntoA.position.x)
        {
            canMove = false;
            gameObject.GetComponentInParent<invocadorEnemigos>().ActivarRutinaGun();
        }
        
    }
    IEnumerator Disparo()
    {
        yield return new WaitForSeconds(cd);
        Instantiate(bullet, shotCtrl.transform.position, shotCtrl.transform.rotation);
        cd = Random.Range(minCd, maxCd);
    }
    
}
