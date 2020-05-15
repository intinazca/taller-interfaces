using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using UnityEngine;


public class CuerpoRigido : MonoBehaviour

{

    // Start is called before the first frame update
    void Start()
    {
        BoxCollider boxCollider = gameObject.AddComponent<BoxCollider>();
        boxCollider.center = new Vector3(0f, 0.01f, 0f);
        boxCollider.size = new Vector3(0.00163381f, 0.02f, 0.001545235f);

    }

    // Update is called once per frame
    void Update()
    {

    }

}
