using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;


public class BotonLuz : MonoBehaviour
{
    public GameObject DirectionalLight;
    public GameObject SpotLight;
    private bool Estado = true;

    void Start()
    {
        DirectionalLight.SetActive(false);
    }

    void Update()
    {
        actualizarEstado();
    }

            public void LuzEscenario()
            {
                if (Estado == false)
                {
                    DirectionalLight.SetActive(true);
                    Estado = true;
                }

                else if (Estado == true)
                {
                    DirectionalLight.SetActive(false);
                    Estado = false;
                }
            }

           public void actualizarEstado()
            {
                if (DirectionalLight == false)
                {
                    Estado = false;
                }
                else if(DirectionalLight==true)
                {
                    Estado = true;
                }
            }
        
}
