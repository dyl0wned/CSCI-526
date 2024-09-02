using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerSpin : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 360;
    private Vector3 axis = new Vector3(0, 0, 1);

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(axis, rotationSpeed * Time.deltaTime);
    }
}
