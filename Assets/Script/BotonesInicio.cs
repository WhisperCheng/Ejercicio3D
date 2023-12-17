using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonesInicio : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Inicio()
    {
        SceneManager.LoadScene("guardado");
    }
    public void Idiomas()
    {
        SceneManager.LoadScene("idiomas");
    }
    public void seleccionado()
    {
        SceneManager.LoadScene("Menu principal");
    }
}
