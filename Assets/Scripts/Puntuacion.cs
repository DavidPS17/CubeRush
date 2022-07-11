using UnityEngine;
using UnityEngine.UI;

public class Puntuacion : MonoBehaviour
{
    public Transform jugador;
    public Text puntuacion;

    // Update is called once per frame
    void Update()
    {
        puntuacion.text = jugador.position.z.ToString("0");
    }
}
