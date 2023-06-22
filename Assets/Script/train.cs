using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class train : MonoBehaviour
{
    [Header("Stats")]
    [SerializeField] float speed;
    [SerializeField] int life;
    float currentSpeed;

    [Header("Objetos")]
    public GameObject target;
    public GameObject[] vagones;
    bool canActivate;
    
    
    
    void Start()
    {
        canActivate = false;
        currentSpeed = speed;
    }

    
    void Update()
    {
        transform.position += new Vector3(0, currentSpeed) * Time.deltaTime;
        if (transform.position.y >= target.transform.position.y)
        {
            currentSpeed = 0;
            canActivate = true;
        }
        if(canActivate)
        {
            Atacar();
        }
    }
    void Atacar()
    {
        for(int i = 0; i < vagones.Length; i++)
        {
            vagones[i].GetComponent<vagon>().ActivarVagon();
            canActivate = false;
            target.SetActive(false);
        }
    }
}
