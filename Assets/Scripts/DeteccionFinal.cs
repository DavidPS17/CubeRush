using UnityEngine;

public class DeteccionFinal : MonoBehaviour
{
    public GameManager GameManager;

    void OnTriggerEnter()
    {
        GameManager.NivelCompletado();
    }
}
