using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ManejadorSalto : MonoBehaviour
{
    public bool suelo;
    public Rigidbody rb;
    public float saltos = 5f;
    private float contador = 0f;
    public float jumpForce = 200f;
    public Text ContadorSaltos;

    // Start is called before the first frame update
    void Start()
    {
        suelo = true;
        ContadorSaltos.text = "Saltos: " + (saltos);
    }

    // Update is called once per frame
    void Update()
    {
        // Saltar
        if (SceneManager.GetActiveScene().buildIndex > 1 && suelo == true && contador < saltos)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Saltar();
            }
        }
        
        // Jetpack izquierdo
        if (SceneManager.GetActiveScene().buildIndex > 1 && contador < saltos && transform.position.x < -7 && transform.position.y < 0.5)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Jetpack();
            }
        }

        // Jetpack derecho
        if (SceneManager.GetActiveScene().buildIndex > 1 && contador < saltos && transform.position.x > 7 && transform.position.y < 0.5)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Jetpack();
            }
        }

        // Bajar
        if (SceneManager.GetActiveScene().buildIndex > 1 && Input.GetKeyDown(KeyCode.LeftShift))
        {
            rb.AddForce(0, -jumpForce * 1.5f, 0);
        }
    }

    void Saltar()
    {
        suelo = false;
        rb.AddForce(0, jumpForce, 0);
        contador++;
        ContadorSaltos.text = "Saltos: " + (saltos - contador);
        Debug.Log(contador);
    }

    void Jetpack()
    {
        rb.AddForce(0, jumpForce * 2, 0);

        while (contador < 5)
        {
            contador++;
        }
        ContadorSaltos.text = "Saltos: " + (saltos - contador);
        Debug.Log(contador);
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Suelo")
        {
            suelo = true;
            Debug.Log("toco suelo");
        }
    }
}
