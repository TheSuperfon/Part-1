using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    float UpAndDown;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpAndDown = Input.GetAxis("Vertical");
        


        transform.Translate(0, UpAndDown * 8 * Time.deltaTime, 0);
    }
}
