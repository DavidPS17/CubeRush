using UnityEngine;

public class DeteccionTuto1 : MonoBehaviour
{
    public Canvas info;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter()
    {
        info.enabled = true;
    }
}
