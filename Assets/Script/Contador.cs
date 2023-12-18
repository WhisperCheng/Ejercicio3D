using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.SceneManagement;

public class Contador : MonoBehaviour
{

    public int monedas;
    public AudioSource sonidoFX;
    float cooldown = 0f;

    // Start is called before the first frame update
    void Start()
    {
        monedas = 0;

        sonidoFX = GameObject.Find("FondoFX").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        cooldown += Time.deltaTime;

        if (monedas == 4)
        {
            SceneManager.LoadScene("Final");
            sonidoFX.Stop();
        }
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Moneda" && cooldown > 1.1)
        {
            monedas++;
            cooldown = 0f;
        }
    }
}
