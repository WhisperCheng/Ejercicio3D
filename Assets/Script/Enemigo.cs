using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemigo : MonoBehaviour
{

    public GameObject objetivo;
    AudioSource fondoFX;
    public float velocidad;
    // Start is called before the first frame update
    void Start()
    {
        velocidad = 8f;
        fondoFX = GameObject.Find("FondoFX").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, objetivo.transform.position, velocidad * Time.deltaTime);
        transform.LookAt(objetivo.transform.position);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Personaje") 
        {
            SceneManager.LoadScene("Final");
            fondoFX.Stop();
        }
    }
}
