using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaArquera : MonoBehaviour
{

    public float velMov = 5.0f;
    public float velRot = 200.0f;
    private Animator anim;
    public float x, y;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        transform.Rotate(0, x * Time.deltaTime * velRot, 0);
        transform.Translate(0, 0, y * Time.deltaTime * velMov);

        anim.SetFloat("VelX", x);
        anim.SetFloat("VelY", y);
    }
}
