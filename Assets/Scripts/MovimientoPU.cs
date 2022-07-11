using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPU : MonoBehaviour
{
    public Rigidbody rb;
    public Vector3 velocidad;
    public Vector3 velocidadR;

    public float tiempoEspera;
    //public Transform rotacion;

    void Start()
    {
        rb.angularVelocity = velocidadR;
        Invoke("Subir", 0f);
    }

    void Subir()
    {
        //rb.AddForce(0, 0.001f * Time.deltaTime, 0);
        rb.velocity = velocidad;
        Invoke("Bajar", tiempoEspera);
    }
    void Bajar()
    {
        //rb.AddForce(0, -0.001f * Time.deltaTime, 0);
        rb.velocity = -velocidad;
        Invoke("Subir", tiempoEspera);
    }
}
