using UnityEngine;

public class LogicaPU : MonoBehaviour
{
    //public GameObject EfectoRecogida;

    void OnCollisionEnter(Collision collisionInfo)
    {
        //Instantiate(EfectoRecogida, transform.position, transform.rotation);
        if (collisionInfo.collider.name == "Jugador")
        {
            Destroy(gameObject);
        }
    }
}
