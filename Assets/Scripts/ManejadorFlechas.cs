using UnityEngine;
using UnityEngine.UI;

public class ManejadorFlechas : MonoBehaviour
{
    public Image flechaVerde;
    public Image flechaAzulOscuro;
    public Image flechaNaranja;
    public Image flechaAmarillo;

    bool activeVerde = false;
    bool activeAzulOscuro = false;
    bool activeNaranja = false;
    //bool activeAmarillo = false;

    private colisionesCubo colisionesCubo;

    void Start()
    {
        colisionesCubo = FindObjectOfType<colisionesCubo>();
    }

    public void Verde()
    {
        activeVerde = !activeVerde;
        flechaVerde.enabled = activeVerde;
    }

    public void AzulOscura()
    {
        activeAzulOscuro = !activeAzulOscuro;
        flechaAzulOscuro.enabled = activeAzulOscuro;
    }

    public void Naranja()
    {
        activeNaranja = !activeNaranja;
        flechaNaranja.enabled = activeNaranja;
    }

    public void Amarilla()
    {
        if(colisionesCubo.active == false)
        {
            flechaAmarillo.enabled = true;
        }else if (colisionesCubo.active == true)
        {
            flechaAmarillo.enabled = false;
        }

        //activeAmarillo = !activeAmarillo;
        //flechaAmarillo.enabled = activeAmarillo;
    }
}
