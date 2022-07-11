using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuEntrenamiento : MonoBehaviour
{
    Canvas canvas;

    void Start()
    {
        canvas = GetComponent<Canvas>();
        canvas.enabled = false;
    }

    
    void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                canvas.enabled = false;
            }
        }
    }

    public void esquivar()
    {

    }

    public void saltos()
    {

    }

    public void formas()
    {

    }

    public void powerUps()
    {

    }

    public void volver()
    {
        canvas.enabled = false;
    }
}
