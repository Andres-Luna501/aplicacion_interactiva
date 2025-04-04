using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void BotonInicio()
    {
        SceneManager.LoadScene(1);
    }


    public void BotonSalir()
    {
        Debug.Log("salir del juego");
        Application.Quit();
    }

    public void EnlaceInstagram(string enlace)
    {
        Application.OpenURL(enlace);
    }

    public void EnlaceFacebook(string enlace)
    {
        Application.OpenURL(enlace);
    }
    
    public void EnlaceX(string enlace)
    {
        Application.OpenURL(enlace);
    }
}
