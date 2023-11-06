using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara3D : MonoBehaviour
{
    private Rigidbody movimiento;
    public float velocidad;

    // Start is called before the first frame update
    void Start()
    {
        movimiento = GetComponent<Rigidbody>();
        velocidad = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        float movHorizontal = Input.GetAxis("Horizontal");
        float movVertical = Input.GetAxis("Vertical");

        movimiento.velocity = new Vector3(movHorizontal * velocidad, movimiento.velocity.y, movVertical * velocidad);
    }
}
