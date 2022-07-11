using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public Canvas controles;
    public Canvas niveles;
    public Canvas entrenamiento;

    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Niveles()
    {
        niveles.enabled = true;
    }
    public void Controles()
    {
        controles.enabled = true;
    }

    public void Entrenamiento()
    {
        entrenamiento.enabled = true;
    }
    public void salir()
    {
        Application.Quit();
    }
    public void TrainingDodge()
    {
        SceneManager.LoadScene(12);
    }
    public void TrainingFormas()
    {
        SceneManager.LoadScene(13);
    }
    public void TrainingJump()
    {
        SceneManager.LoadScene(14);
    }
    public void TrainingPU()
    {
        SceneManager.LoadScene(15);
    }
}
