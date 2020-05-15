using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARENA : MonoBehaviour
{
    public GameObject arena;
    int estado = 0;

    void Start()
    {
        arena.SetActive(false);
    }

    void Update()
    {

    }
    //DirectionalLight.SetActive(false);

    public void ArenaEscenario()
    {
        if (estado == 0)
        {
            arena.SetActive(true);
            estado = 1;
        }

        else if (estado == 1)
        {
            arena.SetActive(false);
            estado = 0;
        }
    }
}
