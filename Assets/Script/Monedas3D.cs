using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monedas3D : MonoBehaviour
{

    private ParticleSystem particulas;
    bool pillado;


    // Start is called before the first frame update
    void Start()
    {
        particulas = GetComponent<ParticleSystem>();
        particulas.Stop();
        pillado = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (pillado == true)
        {
            Destroy(gameObject, particulas.duration);
            
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Personaje")
        {
            pillado = true;
            particulas.Play();
        }
    }
}
