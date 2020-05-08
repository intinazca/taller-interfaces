using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuP : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void play()
    {
        //cuando corre el play cambia la escena a 1 que es la del juego
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    //boton de salir del juego
    public void salir()
    {
        Application.Quit();
        Debug.Log("salir");
    }

    public void atras()
    {
        //cuando corre el play cambia la escena a 0 que es la del menu principal
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);

    }
}

