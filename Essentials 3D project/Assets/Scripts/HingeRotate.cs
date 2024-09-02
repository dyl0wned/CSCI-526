using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HingeRotate : MonoBehaviour
{
    public Vector3 rotateChange;
    public float maxRotate;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotateChange * Time.deltaTime);
        //Debug.Log(transform.rotation);
        if( Mathf.Abs(transform.localRotation.y) > maxRotate )
        {
            rotateChange *= -1;
        }
    }
}
