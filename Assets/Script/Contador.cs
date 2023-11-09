using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Contador : MonoBehaviour
{

    public TMP_Text contador;
    public int monedas;
    public GameObject canvasPadre;
    public TMP_Text tiempo;
    float segundos = 0;

    // Start is called before the first frame update
    void Start()
    {
        monedas = 0;
        segundos = 0;

        canvasPadre = GameObject.Find("CanvasPadre");
        canvasPadre.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        segundos += Time.deltaTime;

        tiempo.text = "Tiempo = " + segundos.ToString("F2");
        if (monedas == 3)
        {
            Time.timeScale = 0f;
            canvasPadre.SetActive(true);
        }
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Moneda")
        {
            monedas++;
            contador.text = "Monedas recogidas = " + monedas;
        }
    }
}
