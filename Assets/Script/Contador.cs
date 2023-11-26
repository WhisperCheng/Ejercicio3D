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
    public AudioSource sonidoFX;
    float segundos = 0;
    float cooldown = 0f;

    // Start is called before the first frame update
    void Start()
    {
        monedas = 0;
        segundos = 0;

        canvasPadre = GameObject.Find("CanvasPadre");
        canvasPadre.SetActive(false);

        sonidoFX = GameObject.Find("FondoFX").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        segundos += Time.deltaTime;

        cooldown += Time.deltaTime;

        tiempo.text = "Tiempo = " + segundos.ToString("F2");
        if (monedas == 4)
        {
            Time.timeScale = 0f;
            canvasPadre.SetActive(true);
            sonidoFX.Stop();
        }
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Moneda" && cooldown > 1.1)
        {
            monedas++;
            contador.text = "Monedas recogidas = " + monedas;
            cooldown = 0f;
        }
    }
}
