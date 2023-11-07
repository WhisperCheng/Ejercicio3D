using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{

    private Rigidbody cuerpo;
    public float velocidad;
    float movHorizontal, movVertical;
    bool tocando;

    // Start is called before the first frame update
    void Start()
    {
        cuerpo = GetComponent<Rigidbody>();
        velocidad = 10f;
        tocando = false;
    }

    // Update is called once per frame
    void Update()
    {
        movHorizontal = Input.GetAxis("Horizontal");
        movVertical = Input.GetAxis("Vertical");

        cuerpo.velocity = new Vector3(movHorizontal * velocidad, cuerpo.velocity.y, movVertical * velocidad);

        Input.GetButtonDown("Jump");

        if (tocando && Input.GetButtonDown("Jump"))
        {
            cuerpo.AddForce(Vector3.up * 6, ForceMode.Impulse);
            tocando = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Suelo")
        {
            tocando = true;
        }
    }
}
