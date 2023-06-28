using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerTerreno : MonoBehaviour
{
    public GameObject controlSpawners;
    [SerializeField] GameObject[] terrenos;
    public Transform cambioSpawners;


    void Update()
    {

    } 
    public void GeneradorDeTerreno()
    {
        int x = Random.Range(0, terrenos.Length);
        Instantiate(terrenos[x],transform);
        if(terrenos[x].transform.position.y <= cambioSpawners.position.y)
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
