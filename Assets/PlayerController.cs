using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 22.5f;
    public float turnSpeed = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float steering = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, steering * turnSpeed * Time.deltaTime);
        transform.Translate(Vector3.forward * Time.deltaTime * speed); ; 
    }
}
