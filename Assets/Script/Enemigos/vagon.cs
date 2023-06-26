using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vagon : MonoBehaviour
{
    public GameObject[] bandits;
    int i = 0;
    public int contador = 0;
    bool canCheck;
    
    private void Update()
    {
        if (contador <= 0)
        {
            gameObject.GetComponentInParent<train>().DetenerTren();
               
        }
    }
    public void ActivarVagon()
    {
        contador = bandits.Length;
        
        i = 0;
        do
        {
            bandits[i].SetActive(true);
            bandits[i].GetComponent<vagonEnemy>().ActivarDisparo();
            i++;
            
        }
        while (i < bandits.Length);

    }
    public void DesactivarVagon()
    {
        
        for(int i = 0; i < bandits.Length; i++)
        {
            bandits[i].SetActive(false);
            bandits[i].GetComponent<vagonEnemy>().ResetearValores();
            contador++;
        }
        
    }
    

}
