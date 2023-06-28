using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int life;
    int currentLife;
    [SerializeField] GameObject gameOver;
    void Start()
    {
        currentLife = life; 
    }

    
    void Update()
    {
        if(currentLife <=0)
        {
            gameOver.SetActive(true);
            Time.timeScale = 0;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        currentLife -= collision.gameObject.GetComponent<Bullets>().damage;

    }
}
