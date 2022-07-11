using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControles : MonoBehaviour
{
    bool active;
    Canvas canvas;

    public Canvas pausa;

    void Start()
    {
        canvas = GetComponent<Canvas>();
        canvas.enabled = false;
    }
    public void Volver()
    {
        canvas.enabled = false;
        pausa.enabled = true;
    }
}
