using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    float UpAndDown;
    //float Rotation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpAndDown = Input.GetAxis("Vertical");
        //Rotation = Input.GetAxis("Horizontal");
        transform.Translate(0, UpAndDown * 10 * Time.deltaTime, 0);
        //transform.Rotate(Vector3.forward, Rotation * 50 * Time.deltaTime);

    }
}
