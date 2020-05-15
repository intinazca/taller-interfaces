using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;


public class BotonLuz : MonoBehaviour
{
    public GameObject DirectionalLight;
    public GameObject SpotLight;
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
            SpotLight.SetActive(false);
            
            estado = 1;
            print("linterna on");
        }

        else if (estado == 1)
        {
            DirectionalLight.SetActive(false);
            SpotLight.SetActive(true);
            print("linterna off");
            estado = 0;

        }
    }

}
