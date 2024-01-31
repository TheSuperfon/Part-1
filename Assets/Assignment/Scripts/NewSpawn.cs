using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewSpawn : MonoBehaviour
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
        if (transform.position.y >= 0)
        {
            transform.Translate(-UpAndDown * 18 * Time.deltaTime, 0, 0);//moves it opposite to the puck and offsets it by a lot

        }
        if (transform.position.y < 0)
        {
            transform.Translate(-UpAndDown * 10 * Time.deltaTime, 0, 0);//moves it opposite to the puck and offsets it by a bit

        }

        
    }

    
}
