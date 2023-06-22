using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vagon : MonoBehaviour
{
    public GameObject[] bandits;

    public void ActivarVagon()
    {
        
        for (int i = 0; i < bandits.Length; i++)
        {
            bandits[i].SetActive(true);
            Debug.Log(bandits[1].name + "activado");    
        }

    }
    

}
