using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public float speed = 5.0f;
    public float rotationSpeed = 180f;


    void Update()
    {
       

        if (Input.GetKey(KeyCode.W))
        {
         
            transform.position += transform.up * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            
            transform.position -= transform.up * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
           
            transform.position -= transform.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
          
            transform.position += transform.right * speed * Time.deltaTime;
        }


        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");


        transform.Translate(Vector3.forward * Time.deltaTime * speed * vertical);
        transform.Rotate(Vector3.forward * Time.deltaTime * rotationSpeed * horizontal);



    }
}
