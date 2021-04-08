using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InserirObjeto : MonoBehaviour
{
    public GameObject[] objectsMudar;
    public GameObject objetoCubo;
    public Canvas canvasMudar;
    private int mudanca = 0;
    public Transform lugarParaPor;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButton(0))
        {
            

                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit = new RaycastHit();
                // Casts the ray and get the first game object hit
                Physics.Raycast(ray, out hit);

                if (hit.collider.gameObject == objetoCubo)
                {

                    canvasMudar.gameObject.SetActive(true);
                    if (hit.collider.gameObject == objetoCubo)
                    {
                        mudanca = 1;
                    }

                   

                }
            
        }
    }

    public void mudaObjeto()
    {

        if (mudanca == 1)
        {

           
            objectsMudar[0] =
                Instantiate(objectsMudar[0], lugarParaPor.transform.position, lugarParaPor.transform.rotation) as GameObject;

        }

        canvasMudar.gameObject.SetActive(false);
    }
}
