using UnityEngine;

public class DeteccionControlesFormas : MonoBehaviour
{
    public GameManager GameManager;

    void OnTriggerEnter()
    {
        GameManager.Control();
    }
}
