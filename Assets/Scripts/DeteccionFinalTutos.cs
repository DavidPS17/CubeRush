using UnityEngine;
using UnityEngine.SceneManagement;

public class DeteccionFinalTutos : MonoBehaviour
{
    private colisionesCubo colisionesCubo;

    void Start()
    {
        colisionesCubo = FindObjectOfType<colisionesCubo>();
    }

    void OnTriggerEnter()
    {
        SceneManager.LoadScene(0);
        colisionesCubo.fijarForma = false;
    }
}
