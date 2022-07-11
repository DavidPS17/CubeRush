using UnityEngine;

public class SeguirJugador : MonoBehaviour
{
    public Transform jugador;
    public Vector3 offset; // Desplazamiento de la cámara respecto al jugador (cubo)

    void Update()
    {
        // Debug.Log(jugador.position);
        transform.position = jugador.position + offset;
    }
}
