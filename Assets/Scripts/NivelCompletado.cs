using UnityEngine;
using UnityEngine.SceneManagement;

public class NivelCompletado : MonoBehaviour
{
    void CargarSiguienteNivel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
