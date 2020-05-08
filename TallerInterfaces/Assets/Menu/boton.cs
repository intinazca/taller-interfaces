using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;


public class boton : MonoBehaviour
{
    void OnGUI()
    {
        if (GUI.Button(new Rect(10, 10, 150, 100), "Boton Scrip"))
        {

            //INSERTAR AQUI TODO EL CODIGO
            print("boton construido por scrip");
        }
    }

    void Start()
    {
        
    }

  
    void Update()
    {
     
    }


  
}
