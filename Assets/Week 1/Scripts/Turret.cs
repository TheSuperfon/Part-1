using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{

    float speed = 50f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float keyboardInput = Input.GetAxis("Vertical");
        transform.Rotate(Vector3.forward, keyboardInput *  speed * Time.deltaTime);
    }
}
