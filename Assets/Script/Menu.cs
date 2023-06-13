using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public bool esPausa;
    public GameObject menuPausa;
    
    public void CargarEscena(int nScene)
    {
        SceneManager.LoadScene(nScene);
    }
    private void Update()
    {
        if(esPausa)
        {
            if(Input.GetKeyDown(KeyCode.Escape))
            {
                MenuPausa();
            } 
        }
    }

    public void MenuPausa()
    {
        menuPausa.SetActive(true);
        ControlTiempo(0);
    }
    public void ControlTiempo(int scale)
    {
        Time.timeScale = scale;
    }

}
