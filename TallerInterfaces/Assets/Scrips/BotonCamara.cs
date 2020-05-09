using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class BotonCamara : MonoBehaviour
{
   public GameObject CamaraPersonaje;
    public GameObject camaraPlanoGeneral;
    //  var Cam = GameObject = new GameObject("CamaraPersonaje");
    //var CamaraPersonaje = Camera;
    // var camaraPlanoGeneral = Camera;
    int estado =0 ;

    void Start()
    {
      //  CamaraPersonaje.enable = true;
       // camaraPlanoGeneral.enable = false;
    }


    void Update()
    {
      //  if (Input.GetButton("Camara"))
       // { 
          //  CamaraPersonaje.enable = false;
            //camaraPlanoGeneral.enable = true;
       // }
    }

    public void CambiarCamara()
    {   
        if (estado==0)
        {
            CamaraPersonaje.SetActive(false);
            camaraPlanoGeneral.SetActive(true);
            estado = 1;
            print("camara lejos");
        }

        else if  (estado == 1)
       {
            CamaraPersonaje.SetActive(true);
            camaraPlanoGeneral.SetActive(false);
           print("camar primera persona");
            estado = 0;

        }
    
    }
 
}
