using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public Vector3 initialImpulse;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(initialImpulse, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
