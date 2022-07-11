using UnityEngine;

public class DeteccionControlesJetpack : MonoBehaviour
{
    public GameManager GameManager;

    void OnTriggerEnter()
    {
        GameManager.Control();
    }
}
