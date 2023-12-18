using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonesInicio : MonoBehaviour
{
    public GameObject botonInicio;
    public GameObject botonIdiomas;
    public GameObject menu;
    float duracion = 2;
    // Start is called before the first frame update
    void Start()
    {
        LeanTween.scale(botonInicio, new Vector3(1, 1, 1), duracion).setEase(LeanTweenType.easeInSine);
        LeanTween.scale(botonIdiomas, new Vector3(1, 1, 1), duracion).setEase(LeanTweenType.easeInSine);
        LeanTween.move(menu, menu.transform.position - (Vector3.up * 40), duracion).setEase(LeanTweenType.easeInOutElastic);
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
