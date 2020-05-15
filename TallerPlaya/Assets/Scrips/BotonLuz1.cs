using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;


public class BotonLuz1 : MonoBehaviour
{
    public GameObject DirectionalLight;
    int estado =0;

    void Start()
    {
        DirectionalLight.SetActive(false);
    }

    void Update()
    {
        
    }
    //DirectionalLight.SetActive(false);

   public void LuzEscenario()
      {
        if (estado == 0)
        {
            DirectionalLight.SetActive(true);
            estado = 1;
        }

        else if (estado == 1)
        {
            DirectionalLight.SetActive(false);
            estado = 0;
        }
    }

}
