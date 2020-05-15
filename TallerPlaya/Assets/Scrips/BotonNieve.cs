using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonNieve : MonoBehaviour
{
    public GameObject nieve;
    int estado = 0;

    void Start()
    {
        nieve.SetActive(false);
    }

    void Update()
    {

    }
    //DirectionalLight.SetActive(false);

    public void NeveEscenario()
    {
        if (estado == 0)
        {
            nieve.SetActive(true);
            estado = 1;
        }

        else if (estado == 1)
        {
            nieve.SetActive(false);
            estado = 0;
        }
    }
}
