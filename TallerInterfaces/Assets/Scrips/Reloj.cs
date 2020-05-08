using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Reloj : MonoBehaviour
{
    [Tooltip("tiempo inicial en segundos")]
    public int tiempoInicial;
    [Tooltip("escala de tiempo reloj")]
    [Range(-10.0f, 10.0f)]
    public float escalaTiempo= 1; //que tan rapido corre el reloj
    //si esta en cero el tiempo no pasa y si lo colocamos en 2, multiplica por 2 el tiempo
    // Start is called before the first frame update

    private Text myText;
    private float tiempoFrame =0f; //tiempo del fotograma con la escala de tiempo
    private float tiempoEnSegundos = 0f; //s el tiempo a mostrar en segundos
    private float tiempoPausado, escalatiempoInicio; //guarda el tiempo al pausar el juego
    private bool estaPaused = false;

    void Start()
    {
        //creamos las condiciones para inicializar el timer

        escalatiempoInicio = escalaTiempo; //cuando inicie el juego va a guarda  nuestra variable la escala de tiempo inicial
        myText= GetComponent<Text>(); //else texto obtiene el componente de tiempo
        tiempoEnSegundos = tiempoInicial;//mostramos los segundos con el valor inicial del tiempo
        ActualizarReloj(tiempoInicial); //funcion que calculara los tiempos
    }

    // Update is called once per frame
    void Update() //el update corre en cada fram
    {
        if (!estaPaused) { // si no esta pausado el reloj entra a correr
            //codifo para aculaizar el tiempo
            // la sgt variable rep[resenrta el tiempo  de cada frame considerada la escala de tiempo
            tiempoFrame = Time.deltaTime * escalaTiempo;
            tiempoEnSegundos += tiempoFrame; //acumula el tiempo transcurrido para mostrarlo en el reloj
            ActualizarReloj(tiempoEnSegundos); //en cada frame actualiza el reloj en cada timepo 
        }
      
    }
    //funcion para actualizar reloj
    public void ActualizarReloj(float tiempoEnSegundos)
    {
        
        int minutos = 0;
        int segundos = 0;
        string textoDelReloj;

        //cuando entre valor negativo lo pasa a cero para que el timer no se vuelva loco
        if (tiempoEnSegundos < 0) tiempoEnSegundos = 0;

        //calculo del tiempo
        minutos = (int)tiempoEnSegundos / 60; // el int del parentecis transforma el numero resultado en el entero mas cercano
        segundos = (int)tiempoEnSegundos % 60;  

        //pasamos el tiempo a la cadena de caracteres del text
        textoDelReloj = minutos.ToString("00") +":"+ segundos.ToString("00");

        //altualizamos el texto pasandole el texto que contiene el tiempo
        myText.text = textoDelReloj;
    }




    public void Pausa()
    { //cuando undamos escapa pausa el reloj

        if (Input.GetKey(KeyCode.E))
        {
            if (!estaPaused) //verifica que no este pasusado, solo entra cuando no esta pausado el relojk
            {   //si no esta pausado lo vuelve verdadero
                estaPaused = true;
                escalaTiempo = tiempoPausado;
                escalaTiempo = 0; //multiplica por cero el tiempo entonces no suma 

            }
        }
    }

    public void Continuar()
    {
        if (estaPaused) //si el reloj esta pasusado entra
        {
            estaPaused = false; //lo cambia de estado 
            escalaTiempo = tiempoPausado; //coloco la escla de tiempo a la que tiene la pusar
        }
    }
    public void Reiniciar()//resea el reloj al estado inicial
    { 
      estaPaused = false; //false para que transcurra el tiempo normal al reiniciar
        escalaTiempo = escalatiempoInicio;
        tiempoEnSegundos = tiempoInicial;
        ActualizarReloj(tiempoEnSegundos);
    }

}
