using UnityEngine;
using UnityEngine.SceneManagement;

public class colisionesCubo : MonoBehaviour
{
    public bool active = true;
    public float TiempoPU = 4f;

    public MovimientoJugador movement;

    private MovimientoJugador MovimientoJugador;
    private ManejadorSalto ManejadorSalto;
    private ManejadorFlechas ManejadorFlechas;
    private Dificultad dificultad;

    public Vector3 pequeño;
    public bool pequeñoT;
    public bool fijarForma = false;

    public Vector3 fijarAnho;
    public Vector3 fijarAlto;

    public Canvas info;

    int contadorPUInvecible = 0;

    float velOriginal = Dificultad.vel;
    bool velReset = false;
    public float velMitad = Dificultad.vel / 2;
    bool velDoble = false;

    void Start()
    {
        MovimientoJugador = FindObjectOfType<MovimientoJugador>();
        ManejadorSalto = FindObjectOfType<ManejadorSalto>();
        ManejadorFlechas = FindObjectOfType<ManejadorFlechas>();
        dificultad = FindObjectOfType<Dificultad>();
    }

    void Update()
    {

    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        if(active == true)
        {
            if (collisionInfo.collider.tag == "Obstaculos")
            {
                Dificultad.vel = velOriginal;
                velReset = false;

                fijarForma = false;
                movement.enabled = false;
                FindObjectOfType<GameManager>().EndGame();
            }
        }

        if (collisionInfo.collider.tag == "PU Invencible")
        {
            active = false;
            contadorPUInvecible++;

            ManejadorFlechas.Amarilla();
            Invoke("Normalidad", TiempoPU);
        }

        if (collisionInfo.collider.tag == "PU Lentitud")
        {
            if (velReset == false)
            {
                velOriginal = Dificultad.vel;
                velReset = true;
            }

            if (Dificultad.vel < 3250)
            {
                velDoble = true;
            }

            Dificultad.vel = velMitad;
            //MovimientoJugador.forwardForce = MovimientoJugador.forwardForce / 2;
            ManejadorFlechas.Naranja();
            Invoke("NormalVel", TiempoPU);

            Debug.Log(Dificultad.vel);
        }

        if (collisionInfo.collider.tag == "PU Pequeño")
        {
            transform.localScale = transform.localScale / 2;
            pequeñoT = true;
            ManejadorFlechas.AzulOscura();
            Invoke("NormalTam", TiempoPU);
        }

        if (collisionInfo.collider.tag == "PU Rayo Laser")
        {
            Invoke("Normalidad", TiempoPU);
        }

        if (collisionInfo.collider.tag == "PL Salto")
        {
            ManejadorSalto.jumpForce = ManejadorSalto.jumpForce / 2;
            ManejadorFlechas.Verde();
            Invoke("NormalSalto", TiempoPU);
        }

        if (collisionInfo.collider.tag == "Training1")
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + 100, transform.position.z);
            info.enabled = false;

            if (collisionInfo.collider.name == "Training1(plano)")
            {
                fijarForma = true;
                transform.localScale = fijarAnho;
            }
        }

        if (collisionInfo.collider.tag == "Training2")
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + 200, transform.position.z);
            info.enabled = false;

            if (collisionInfo.collider.name == "Training2(alto)")
            {
                fijarForma = true;
                transform.localScale = fijarAlto;
            }
        }

        if (collisionInfo.collider.tag == "Training3")
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + 300, transform.position.z);
            info.enabled = false;
        }

        if (collisionInfo.collider.tag == "Training4")
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + 400, transform.position.z);
            info.enabled = false;
        }
    }

    void Normalidad()
    {
        contadorPUInvecible--;

        if (contadorPUInvecible == 0)
        {
            active = true;
            ManejadorFlechas.Amarilla();
        }
    }

    void NormalVel()
    {
        Dificultad.vel = velOriginal;
        //MovimientoJugador.forwardForce = MovimientoJugador.forwardForce * 2;
        ManejadorFlechas.Naranja();

        if (velDoble == true)
        {
            Dificultad.vel = velMitad;
            velDoble = false;
        }

    }
    void NormalTam()
    {
        pequeñoT = false;
        transform.localScale = transform.localScale * 2;
        transform.position = transform.position + pequeño;
        ManejadorFlechas.AzulOscura();
    }
    void NormalSalto()
    {
        ManejadorSalto.jumpForce = ManejadorSalto.jumpForce * 2;
        ManejadorFlechas.Verde();
    }
}
