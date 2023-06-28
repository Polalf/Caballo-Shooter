using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mapMove : MonoBehaviour
{
    [SerializeField] float speed;
    bool canGen;
    //[SerializeField] Transform sigTerr;
    private void Start()
    {
        canGen = true;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.up * -speed * Time.deltaTime;

        if(transform.position.y <= 0)
        {
            if(canGen)
            {
                gameObject.GetComponentInParent<spawnerTerreno>().GeneradorDeTerreno();
                canGen = false;
            }
        }
            
        if(transform.position.y < -40)
        {
            Destroy(gameObject);
        }
    }
}
