using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public Transform target;
    public Rigidbody rb;
    public float t, speed, force;
    //public Vector3 moveDirection;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    void FixedUpdate()
    {
        
         Vector3 f = target.position = transform.position;
         f = f.normalized;
         f = f * force;
         rb.AddForce(f);
        
        //transform.Translate(moveDirection, Space.Self);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
