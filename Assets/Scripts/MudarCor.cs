using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MudarCor : MonoBehaviour
{

    RaycastHit hit;
    Rigidbody rb;

    public Canvas canvasCor;

    public GameObject[] objects;
    private int contaClick = 0;
    private SpriteRenderer sp;
    private int mudanca = 0;

    public Texture[] texturas;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();



    }

    // Update is called once per frame
    void Update()
    {



        // Check for mouse input
        if (Input.GetMouseButton(0))
        {
            foreach (GameObject j in objects)
            {
                sp = j.GetComponent<SpriteRenderer>();
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                // Casts the ray and get the first game object hit
                Physics.Raycast(ray, out hit);
                if (hit.collider.gameObject == j)
                {
                    print(j.name);
                    canvasCor.gameObject.SetActive(true);
                    if (hit.collider.gameObject == objects[0])
                    {
                        mudanca = 1;
                    }
                    if (hit.collider.gameObject == objects[1])
                    {
                        mudanca = 2;
                    }

                    if (hit.collider.gameObject == objects[2])
                    {
                        mudanca = 3;
                    }
                    if (hit.collider.gameObject == objects[3])
                    {
                        mudanca = 4;
                    }

                }
            }
        }
    }

    public void mudaCorVerde()
    {

        if (mudanca == 1)
        {
            objects[0].GetComponent<Renderer>().material.color = Color.green;
        }
        if (mudanca == 2)
        {
            objects[1].GetComponent<Renderer>().material.color = Color.green;
        }
        if (mudanca == 3)
        {
            objects[2].GetComponent<Renderer>().material.color = Color.green;
        }
        if (mudanca == 4)
        {
            objects[3].GetComponent<Renderer>().material.color = Color.green;
        }

    }
    public void mudaCorVermelho()
    {

        if (mudanca == 1)
        {
            objects[0].GetComponent<Renderer>().material.color = Color.red;
        }
        if (mudanca == 2)
        {
            objects[1].GetComponent<Renderer>().material.color = Color.red;
        }

        if (mudanca == 3)
        {
            objects[2].GetComponent<Renderer>().material.color = Color.red;
        }
        if (mudanca == 4)
        {
            objects[3].GetComponent<Renderer>().material.color = Color.red;
        }

    }
    public void mudaCorAzul()
    {

        if (mudanca == 1)
        {
            objects[0].GetComponent<Renderer>().material.color = Color.blue;
        }
        if (mudanca == 2)
        {
            objects[1].GetComponent<Renderer>().material.color = Color.blue;
        }

        if (mudanca == 3)
        {
            objects[2].GetComponent<Renderer>().material.color = Color.blue;
        }
        if (mudanca == 4)
        {
            objects[3].GetComponent<Renderer>().material.color = Color.blue;
        }

    }

    public void mudaTextura()
    {
        if (mudanca == 1)
        {
            objects[0].GetComponent<Renderer>().material.SetTexture("_MainTex", texturas[0]);

        }
    }
    public void mudaTextura2()
    {
        if (mudanca == 1)
        {
            objects[0].GetComponent<Renderer>().material.SetTexture("_MainTex", texturas[1]);

        }
    }
    public void TiraCanvas()
    {
        canvasCor.gameObject.SetActive(false);
    }
    private void OnMouseDown()
    {

        contaClick++;



        /*if(contaClick % 2 == 0)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.green;
        }else
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
    */
    }

    public void botaoSair()
    {

        canvasCor.gameObject.SetActive(false);
    }
}
