using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MudarObjeto : MonoBehaviour
{
    public Canvas canvasCor;
    private int mudanca = 0;
    public GameObject[] objectsMudar;
    public GameObject objetoInicial;

    public GameObject proximoObjeto;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            foreach (GameObject j in objectsMudar)
            {

                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit = new RaycastHit();
                // Casts the ray and get the first game object hit
                Physics.Raycast(ray, out hit);

                if (hit.collider.gameObject == j)
                {

                    canvasCor.gameObject.SetActive(true);
                    if (hit.collider.gameObject == objectsMudar[0])
                    {
                        mudanca = 1;
                    }

                    print(j.name);

                }
            }
        }
    }

    public void mudaObjeto()
    {

        if (mudanca == 1)
        {

            Destroy(objectsMudar[0]);
            objectsMudar[0] =
                Instantiate(proximoObjeto, objectsMudar[0].transform.position, objectsMudar[0].transform.rotation) as GameObject;

        }
        canvasCor.gameObject.SetActive(false);

    }

    public void mudaParaInicio()
    {
        if (mudanca == 1)
        {
            Destroy(objectsMudar[0]);
            objectsMudar[0] =
                Instantiate(objetoInicial, objectsMudar[0].transform.position, objectsMudar[0].transform.rotation) as GameObject;

        }
        canvasCor.gameObject.SetActive(false);
    }

}
