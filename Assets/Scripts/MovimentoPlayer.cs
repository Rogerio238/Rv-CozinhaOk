using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoPlayer : MonoBehaviour
{
    public CharacterController controlador;
    public float speed = 12f;

    public Canvas canvasCor;
    public Canvas canvasMudar;
    bool estaAtivo = false;
    // Update is called once per frame
    void Update()
    {


        if (canvasCor.gameObject.active == true || canvasMudar.gameObject.active == true)
        {
            estaAtivo = true;
        }
        else
        {
            estaAtivo = false;
        }

        if (estaAtivo == false)
        {
            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");

            Vector3 move = transform.right * x + transform.forward * z;
            controlador.Move(move * speed * Time.deltaTime);
        }
    }
}
