using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRigidbody : MonoBehaviour
{
    public Rigidbody myRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody.useGravity = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
