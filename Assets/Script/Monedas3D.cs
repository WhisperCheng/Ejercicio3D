using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monedas3D : MonoBehaviour
{

    private ParticleSystem particulas;
    AudioSource sonidoFX;
    float cooldown;

    // Start is called before the first frame update
    void Start()
    {
        particulas = GetComponent<ParticleSystem>();
        particulas.Stop();
        sonidoFX = GameObject.Find("MonedasFX").GetComponent<AudioSource>();
        cooldown = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        cooldown += Time.deltaTime;
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Personaje" && cooldown > 1.1)
        {
            Destroy(gameObject, particulas.duration);
            sonidoFX.Play();
            particulas.Play();
            cooldown = 0f;
        }
    }
}
