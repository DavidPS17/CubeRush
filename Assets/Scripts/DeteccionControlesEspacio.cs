using UnityEngine;

public class DeteccionControlesEspacio : MonoBehaviour
{
    public GameManager GameManager;

    void OnTriggerEnter()
    {
        GameManager.Control();
    }
}
