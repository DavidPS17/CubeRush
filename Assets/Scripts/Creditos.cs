using UnityEngine;
using UnityEngine.SceneManagement;

public class Creditos : MonoBehaviour
{
    public void Quit()
    {
        Application.Quit();
    }
    public void Reset()
    {
        SceneManager.LoadScene(0);
    }
}
