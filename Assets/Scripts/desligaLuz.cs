using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class desligaLuz : MonoBehaviour
{
    public Light luzParaDesligar;

    private void Start()
    {
        //Screen.lockCursor = true;
    }
    public void desligarLuz()
    {
        if(luzParaDesligar.intensity > 0)
        {
            luzParaDesligar.intensity = 0;
        }
        else if(luzParaDesligar.intensity == 0)
        {
            luzParaDesligar.intensity = 3.16f;
        }
    }
}
