using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Missile : MonoBehaviour
{
    Vector2 direction = new Vector2(10,0);
    Rigidbody2D rigidbody;
    //float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(1 * speed * Time.deltaTime, 0, 0);
    }

    private void FixedUpdate()
    {
        rigidbody.MovePosition(rigidbody.position + direction * Time.deltaTime);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("I Hit It");
        Destroy(gameObject);
    }


}
