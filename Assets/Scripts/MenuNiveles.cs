using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuNiveles : MonoBehaviour
{
    bool active;
    Canvas canvas;

    public Canvas pausa;

    void Start()
    {
        canvas = GetComponent<Canvas>();
        canvas.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            canvas.enabled = false;
            pausa.enabled = true;
        }
    }

    public void Nivel001()
    {
        if (SceneManager.GetActiveScene().buildIndex != 0)
        {
            pausa.enabled = false;
        }
        canvas.enabled = false;

        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }
    public void Nivel002()
    {
        if (SceneManager.GetActiveScene().buildIndex != 0)
        {
            pausa.enabled = false;
        }
        canvas.enabled = false;

        SceneManager.LoadScene(2);
        Time.timeScale = 1f;
    }
    public void Nivel003()
    {
        if (SceneManager.GetActiveScene().buildIndex != 0)
        {
            pausa.enabled = false;
        }
        canvas.enabled = false;

        SceneManager.LoadScene(3);
        Time.timeScale = 1f;
    }
    public void Nivel004()
    {
        if (SceneManager.GetActiveScene().buildIndex != 0)
        {
            pausa.enabled = false;
        }
        canvas.enabled = false;

        SceneManager.LoadScene(4);
        Time.timeScale = 1f;
    }
    public void Nivel005()
    {
        if(SceneManager.GetActiveScene().buildIndex != 0)
        {
            pausa.enabled = false;
        }
        canvas.enabled = false;

        SceneManager.LoadScene(5);
        Time.timeScale = 1f;
    }

    public void Nivel006()
    {
        if (SceneManager.GetActiveScene().buildIndex != 0)
        {
            pausa.enabled = false;
        }
        canvas.enabled = false;

        SceneManager.LoadScene(6);
        Time.timeScale = 1f;
    }

    public void Nivel007()
    {
        if (SceneManager.GetActiveScene().buildIndex != 0)
        {
            pausa.enabled = false;
        }
        canvas.enabled = false;

        SceneManager.LoadScene(7);
        Time.timeScale = 1f;
    }

    public void Nivel008()
    {
        if (SceneManager.GetActiveScene().buildIndex != 0)
        {
            pausa.enabled = false;
        }
        canvas.enabled = false;

        SceneManager.LoadScene(8);
        Time.timeScale = 1f;
    }

    public void Nivel009()
    {
        if (SceneManager.GetActiveScene().buildIndex != 0)
        {
            pausa.enabled = false;
        }
        canvas.enabled = false;

        SceneManager.LoadScene(9);
        Time.timeScale = 1f;
    }

    public void Nivel010()
    {
        if (SceneManager.GetActiveScene().buildIndex != 0)
        {
            pausa.enabled = false;
        }
        canvas.enabled = false;

        SceneManager.LoadScene(10);
        Time.timeScale = 1f;
    }

    public void Volver()
    {
        canvas.enabled = false;
        pausa.enabled = true;
    }
}
