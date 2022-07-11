using UnityEngine;

public class DeteccionControles : MonoBehaviour
{
    public GameManager GameManager;

    void OnTriggerEnter()
    {
        GameManager.Control();
    }
}
