using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monedas3D : MonoBehaviour
{

    private ParticleSystem particulas;
    AudioSource sonidoFX;



    // Start is called before the first frame update
    void Start()
    {
        particulas = GetComponent<ParticleSystem>();
        particulas.Stop();
        sonidoFX = GameObject.Find("MonedasFX").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Personaje")
        {
            Destroy(gameObject, particulas.duration);
            sonidoFX.Play();
            particulas.Play();
        }
    }
}
