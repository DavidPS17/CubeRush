using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MovimientoJugador : MonoBehaviour
{
    public Rigidbody rb;
    public Vector3 transformacion;
    public Text ContadorSaltos;
    public float LentitudLateral;
    public float VelocityLimit = 20;


    public float forwardForce = 2000f;
    public float sidewaysForce = 80f;
    float sidewaysForceAux;

    bool pequeño;
    private colisionesCubo colisionesCubo;
    private ManejadorSalto manejadorSalto;

    //bool suelo;
    void Start()
    {
        Debug.Log("¡Hola Mundo!");
        //rb.AddForce(0, 200, 500);

        colisionesCubo = FindObjectOfType<colisionesCubo>();
        manejadorSalto = FindObjectOfType<ManejadorSalto>();

        sidewaysForceAux = sidewaysForce;
    }

    // Usar void Update siempre, pero si estamos programando físicas usar void FixedUpdate
    void Update()
    {
        forwardForce = Dificultad.vel;
        //Debug.Log(forwardForce);

        // Añade la fuerza hacia delante
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (manejadorSalto.suelo == false)
        {
            sidewaysForceAux = 40;
        }
        else
        {
            sidewaysForceAux = 80;
        }

        // Mover a la derecha
        if (Input.GetKey("d"))
        {
            sidewaysForce = sidewaysForceAux;
            if (Input.GetKey("d") && Input.GetKey(KeyCode.LeftControl))
            {
                sidewaysForce = sidewaysForceAux / 2;
                Debug.Log(sidewaysForce);
                rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
            Debug.Log(sidewaysForce);
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        

        // Mover a la izquierda
        if (Input.GetKey("a"))
        {
            sidewaysForce = sidewaysForceAux;
            if (Input.GetKey("a") && Input.GetKey(KeyCode.LeftControl))
            {
                sidewaysForce = sidewaysForceAux / 2;
                Debug.Log(-sidewaysForce);
                rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
            Debug.Log(-sidewaysForce);
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        

        if (SceneManager.GetActiveScene().buildIndex > 2)
        {
            // Transformaciones
            if (Input.GetKey("w"))
            {
                if (colisionesCubo.fijarForma == false)
                {
                    if (transform.localScale.x > 0.5)
                    {
                        //rb.transform.Rotate(0, transform.rotation.y, transform.rotation.z);
                        transform.localScale = transform.localScale + transformacion;
                    }
                    if (colisionesCubo.pequeñoT == true && transform.localScale.x > 0.25)
                    {
                        Debug.Log("he llegado w");
                        transform.localScale = transform.localScale + transformacion;
                    }
                }
            }

            if (Input.GetKey("s"))
            {
                if (colisionesCubo.fijarForma == false)
                {
                    if (transform.localScale.y > 0.5)
                    {
                        //rb.transform.Rotate(0, transform.rotation.y, transform.rotation.z);
                        transform.localScale = transform.localScale - transformacion;
                    }
                    if (colisionesCubo.pequeñoT == true && transform.localScale.y > 0.25)
                    {
                        Debug.Log("he llegado s");
                        transform.localScale = transform.localScale - transformacion;
                    }
                }
            }
        }

        if (rb.position.y < -4)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
