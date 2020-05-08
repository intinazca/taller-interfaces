using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Control : MonoBehaviour
{
    //EL MOVIMIENTO ES FRAME POR FRAME

    float velocidad = 7f;


    //EL MOVIMIENTO DE UN JUGADOR DEPENDE DE LOS FPS DE LA APP

    void Update()
    {
        //Movimiento WASD
        //KeyDown
        //KeyUp

        if (Input.GetKey(KeyCode.W))
        {
            //Debug.Log("Estoy undiendo w");
            //transform.position +=Vector3.forward * velocidad * Time.deltaTime;//Forma mas extraña de hacerlo DEBIDO A QUE USA LAS COORDENADAS LOCALES SI SE ROTA PAILA
            //transform.position += transform.forward * velocidad;
            transform.position += transform.forward * velocidad * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {

            transform.position -= transform.right * velocidad * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.S))
        {

            //transform.position -= transform.forward * velocidad;
            transform.position -= transform.forward * velocidad * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {

            transform.position += transform.right * velocidad * Time.deltaTime;

        }

        if (Input.GetKey(KeyCode.Escape))
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);

        }





    }
}