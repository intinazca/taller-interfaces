using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonLluvia : MonoBehaviour
{
    public GameObject StormRain;
    int estado = 0;

    void Start()
    {
        StormRain.SetActive(false);
    }

    void Update()
    {

    }
    //DirectionalLight.SetActive(false);

    public void LluviaEscenario()
    {
        if (estado == 0)
        {
            StormRain.SetActive(true);
            

            estado = 1;
            print("Lluvia on");
        }

        else if (estado == 1)
        {
            StormRain.SetActive(false);
            
            print("Lluvia off");
            estado = 0;

        }
    }

}
