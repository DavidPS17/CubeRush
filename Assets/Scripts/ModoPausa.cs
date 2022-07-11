using UnityEngine;
using UnityEngine.SceneManagement;

public class ModoPausa : MonoBehaviour
{
    bool active;
    Canvas canvas;
    public Canvas controles;
    public Canvas niveles;

    void Start()
    {
        canvas = GetComponent<Canvas>();
        canvas.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            active = !active;
            canvas.enabled = active;
            //Time.timeScale = (active ? 0 : 1f);
            if (active == true)
            {
                Time.timeScale = 0;
            }
            else if (active == false)
            {
                Time.timeScale = 1f;
            }

            controles.enabled = false;
            niveles.enabled = false;
        }
    }

    public void PauseGame()
    {
        canvas.enabled = false;
        Time.timeScale = 1f;
    }
    public void Controles()
    {
        canvas.enabled = false;
        controles.enabled = true;
    }
    public void Niveles()
    {
        canvas.enabled = false;
        niveles.enabled = true;
    }
    public void MenuPrincipal()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }
}
