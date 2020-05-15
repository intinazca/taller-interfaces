using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuego : MonoBehaviour
{
    public GameObject fuego;
    int estado = 0;

    void Start()
    {
        fuego.SetActive(false);
    }

    void Update()
    {

    }
    //DirectionalLight.SetActive(false);

    public void FuegoEscenario()
    {
        if (estado == 0)
        {
            fuego.SetActive(false);
            estado = 1;
        }

        else if (estado == 1)
        {
            fuego.SetActive(true);
            estado = 0;
        }
    }
}
