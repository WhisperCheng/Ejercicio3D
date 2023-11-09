using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara3D : MonoBehaviour
{
    public GameObject personaje;
    bool siguiendo;

    // Start is called before the first frame update
    void Start()
    {
        siguiendo = true;
        personaje = GameObject.Find("Personaje");
    }

    // Update is called once per frame
    void Update()
    {
        if (siguiendo == true) 
        {
            transform.position = new Vector3(personaje.transform.position.x, personaje.transform.position.y + 3, personaje.transform.position.z - 9);
        }
    }
}
