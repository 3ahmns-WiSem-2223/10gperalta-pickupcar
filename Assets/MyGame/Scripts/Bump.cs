using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bump : MonoBehaviour
{
    public float speed = 5.0f; // 
    public float bumpForce = 10.0f; 
    public GameObject looseText;

    private Rigidbody2D rb; 
    
  
    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
        looseText.SetActive(false);

    }

  


    void OnCollisionEnter2D(Collision2D coll)
    {
       
        if (coll.gameObject.tag == "Obstacle")
        {
           
            rb.AddForce(coll.contacts[0].normal * -bumpForce, ForceMode2D.Impulse);
            


        }
    }
}
