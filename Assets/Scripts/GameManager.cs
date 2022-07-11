using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool FinDelJuego = false;

    public float TiempoReSpawn = 2f;
    public GameObject PanelVictoria;
    public GameObject Controles;
    public GameObject Saltos;

    public void NivelCompletado()
    {
        PanelVictoria.SetActive(true);
        Saltos.SetActive(false);
    }

    public void Control()
    {
        Controles.SetActive(true);
    }

    public void EndGame()
    {
        if(FinDelJuego == false)
        {
            FinDelJuego = true;
            Debug.Log("GAME OVER");
            Invoke("Reset", TiempoReSpawn);
        }
    }

    void Reset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
