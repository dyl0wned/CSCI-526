using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float fowardSpeed = 20;
    [SerializeField] private float turnSpeed = 45;

    [SerializeField] private float forwardInput = 0;
    [SerializeField] private float horizontalInput = 0 ;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        forwardInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        // Moves the car forwards based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * fowardSpeed * forwardInput);
        // rotates the car based on horizontal input
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}
