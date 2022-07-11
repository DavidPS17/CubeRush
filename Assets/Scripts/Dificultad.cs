using UnityEngine;
using UnityEngine.SceneManagement;

public class Dificultad : MonoBehaviour
{
    public static float vel = 4000f;
    public Canvas dif;

    private colisionesCubo colisionesCubo;

    public bool diff = false;

    public float facilD = 3250;
    public float mediaD = 4000;
    public float dificilD = 4250;

    // Start is called before the first frame update
    void Start()
    {
        //vel = 4000f;
        colisionesCubo = FindObjectOfType<colisionesCubo>();
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                dif.enabled = false;
            }
        }
    }

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void facil()
    {
        vel = facilD;
        colisionesCubo.velMitad = vel / 2;
        Debug.Log(vel);
        diff = true;
    }

    public void media()
    {
        vel = mediaD;
        Debug.Log(vel);
        diff = false;
    }

    public void alta()
    {

    }

    public void dificultad()
    {
        dif.enabled = true;
    }

    public void volver()
    {
        dif.enabled = false;
    }
}
