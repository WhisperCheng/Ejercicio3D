using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara3D : MonoBehaviour
{
    public GameObject personaje;
    bool TerceraPersona;
    bool PrimeraPersona;
    float tiempo;

    // Start is called before the first frame update
    void Start()
    {
        TerceraPersona = true;
        tiempo = 0f;
        personaje = GameObject.Find("Personaje");
    }

    // Update is called once per frame
    void Update()
    {
        if (TerceraPersona == true) 
        {
            transform.position = new Vector3(personaje.transform.position.x, personaje.transform.position.y + 3, personaje.transform.position.z - 9);
            tiempo += Time.deltaTime;
        }
        if (TerceraPersona == true && Input.GetKeyDown(KeyCode.C) && tiempo > 0.1) 
        {
            TerceraPersona = false;
            PrimeraPersona = true;
            tiempo = 0f;
            Debug.Log("Estas en primera persona");
        }
        if (PrimeraPersona == true)
        {
            transform.position = new Vector3(personaje.transform.position.x, personaje.transform.position.y, personaje.transform.position.z);
            tiempo += Time.deltaTime;
        }
        if (PrimeraPersona == true && Input.GetKeyDown (KeyCode.C) && tiempo > 0.1) 
        {
            TerceraPersona = true;
            PrimeraPersona = false;
            tiempo = 0f;
            Debug.Log("Estas en tercera personas");
        }
    }
}
