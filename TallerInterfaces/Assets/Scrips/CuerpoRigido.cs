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
        CapsuleCollider capsuleCollider = gameObject.AddComponent<CapsuleCollider>();
        Rigidbody gameObjectsRigidBody = gameObject.AddComponent<Rigidbody>();
        //gameObject.AddComponent<Rigidbody>();
        gameObjectsRigidBody.mass = 5;

    }

    // Update is called once per frame
    void Update()
    {

    }

}
