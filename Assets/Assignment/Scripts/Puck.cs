using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puck : MonoBehaviour
{
    public float topSpeed = 140; //
    public float puckSpeed = 400;
    Rigidbody2D puckbody;

    public GameObject NewPuck;
    public Transform NewSpawn;

    //Start is called before the first frame update
    void Start()
        {
            puckbody = GetComponent<Rigidbody2D>(); //allows the rigidbody2d to be referenced in future lines of code (this is the body that force/torque will be added to)
            
        }

     //Update is called once per frame
        void Update()
        {
            
        }
    
        private void FixedUpdate()
        {
            Vector2 MovePuck = transform.up * puckSpeed * Time.deltaTime; //is the force that pushes the puck in the forward direction
        /*if (puckbody.velocity.magnitude < topSpeed) //
        {
            puckbody.AddForce(MovePuck); //adds force to rigid body that allows the puck to move
        }*/
            puckbody.AddForce(MovePuck); //adds force to rigid body that allows the puck to move
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        puckSpeed *= -1;//reverses movement of puck
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Instantiate(NewPuck, NewSpawn.position, NewSpawn.rotation);


        Destroy(gameObject);
    }


}
