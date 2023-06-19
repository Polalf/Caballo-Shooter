using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerTerreno : MonoBehaviour
{
    public GameObject controlSpawners;
    public GameObject[] terrenos;
    public Transform sigTerreno;


    void Update()
    {

    } 
    void GeneradorDeTerreno()
    {
        int x = Random.Range(0, terrenos.Length);
        Instantiate(terrenos[x], transform.position, transform.rotation);
        if(terrenos[x].transform.up == sigTerreno.position)
        {
            switch (x)
            {
                case 0:
                    controlSpawners.GetComponent<Spawn>().ControlDeSpawners("Base");
                    break;
                case 1:
                    controlSpawners.GetComponent<Spawn>().ControlDeSpawners("DesactivarIzquierda");
                    break;
                case 2:
                    controlSpawners.GetComponent<Spawn>().ControlDeSpawners("DesactivarCentro");
                    break;
                case 3:
                    controlSpawners.GetComponent<Spawn>().ControlDeSpawners("DesactivarDerecha");
                    break;
                default:

                    break;
            }

        }
    }
}
