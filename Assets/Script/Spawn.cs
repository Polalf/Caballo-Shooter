using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [Header("Control de Spawns")]

    public float tiempoSpawn;
    float timer;

    public GameObject[] spawns;

    [Header("Control de Obstaculos")]
    public GameObject[] Cactus, Rocas;
    public int maxCactus, maxRocas;
    int currentCactus, currentRocas;
    bool canCactus, canRocas;
    private void Start()
    {
        currentCactus = 0;
        currentRocas = 0;
    }


    void Update()
    {
        if (currentCactus >= maxCactus)
        {
            canCactus = false;
        }
        else
        {
            canCactus = true;
        }

        if(currentRocas >= maxRocas)
        {
            canRocas = false;
        }
        else
        {
            canRocas = true;
        }

       if(timer >= tiempoSpawn)
       {
            Spawnear();
       }
    }

    void Spawnear()
    {
        if(canCactus)
        {
            int nSpawn = Random.Range(0, spawns.Length);
            int xCactus = Random.Range(0, Cactus.Length);
            Instantiate(Cactus[xCactus], spawns[nSpawn].transform.position, spawns[nSpawn].transform.rotation);
            timer = 0;
            currentCactus++;
        }
        if(canRocas)
        {
            int nSpawn = Random.Range(0, spawns.Length);
            int xRocas = Random.Range(0, Rocas.Length);
            Instantiate(Rocas[xRocas], spawns[nSpawn].transform.position, spawns[nSpawn].transform.rotation);
            timer = 0;
            currentRocas++;
        }
       
    }
    public void ControlDeSpawners(string terrenoInst)
    {
        if(terrenoInst =="DesactivarIzquierda")
        {
            spawns[0].SetActive(false);
            spawns[1].SetActive(false);

            spawns[2].SetActive(true);
            spawns[3].SetActive(true);
            spawns[4].SetActive(true);
        }
        else if (terrenoInst == "DesactivarCentro")
        {
            spawns[0].SetActive(true);
            spawns[1].SetActive(true);

            spawns[2].SetActive(false);

            spawns[3].SetActive(true);
            spawns[4].SetActive(true);
        }
        else if (terrenoInst == "DesactivarDerecha")
        {
            spawns[0].SetActive(true);
            spawns[1].SetActive(true);
            spawns[2].SetActive(true);

            spawns[3].SetActive(false);
            spawns[4].SetActive(false);
        }
        else
        {
            spawns[0].SetActive(true);
            spawns[1].SetActive(true);
            spawns[2].SetActive(true);
            spawns[3].SetActive(true);
            spawns[4].SetActive(true);
        }
    }
}
