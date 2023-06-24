using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vagon : MonoBehaviour
{
    public GameObject[] bandits;
    int i = 0;
    public int contador = 0;
   
    private void Start()
    {
        
        contador = bandits.Length;
    }
    private void Update()
    {
        if(contador <= 0)
        {
            gameObject.GetComponentInParent<train>().DetenerTren();
        }
        
    }
    public void ActivarVagon()
    {
        i = 0;
        do
        {
            bandits[i].SetActive(true);
            //Debug.Log(bandits[1].name + "activado");
            i++;
            
        }
        while (i < bandits.Length);

    }
    public void DesactivarVagon()
    {
        i = 0;
        do
        {
            bandits[i].SetActive(false);
            bandits[i].GetComponent<vagonEnemy>().ActivarDisparo();
            //Debug.Log(bandits[1].name + "activado");
            i++;
        }
        while (i < bandits.Length);
    }
    

}
