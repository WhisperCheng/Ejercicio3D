using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Personaje : MonoBehaviour
{

    private Rigidbody cuerpo;
    float movHorizontal, movVertical;
    int longitud = 1;
    bool tocando;
    bool dobleSalto;
    public float cooldown;
    public float velocidad;

    // Start is called before the first frame update
    void Start()
    {
        cuerpo = GetComponent<Rigidbody>();
        velocidad = 10f;
        cooldown = 5;
    }

    // Update is called once per frame
    void Update()
    {
        cooldown += Time.deltaTime;

        movHorizontal = Input.GetAxis("Horizontal");
        movVertical = Input.GetAxis("Vertical");

        cuerpo.velocity = new Vector3(movHorizontal * velocidad, cuerpo.velocity.y, movVertical * velocidad);

        if (Input.GetKeyDown(KeyCode.R) && cooldown > 5)
        {
            velocidad = 20f;
            cuerpo.velocity = new Vector3(movHorizontal * velocidad, cuerpo.velocity.y, movVertical * velocidad);
            Debug.Log("Boost de velocidad");
            cooldown = 0;
        }
        else if (cooldown > 2)
        {
            velocidad = 10f;
            cuerpo.velocity = new Vector3(movHorizontal * velocidad, cuerpo.velocity.y, movVertical * velocidad);

        }

        Vector3 origen = transform.position;
        Vector3 direccion = -transform.up;

        RaycastHit hit;

        if (Physics.Raycast(origen, direccion, out hit, longitud)) 
        {
            tocando = true;

            if (tocando == true && Input.GetButtonDown("Jump")) 
            {
                cuerpo.AddForce(Vector3.up * 6, ForceMode.Impulse);
                dobleSalto = true;
            }
        }
        else if (dobleSalto == true && Input.GetButtonDown("Jump"))
        {
            cuerpo.AddForce(Vector3.up * 6, ForceMode.Impulse);
            dobleSalto = false;
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawLine(-transform.up, transform.position);
    }
}
