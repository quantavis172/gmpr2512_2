using System;
using UnityEngine;

public class Bullet : MonoBehaviour
{


   
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      
    }
 
   private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Alien"))
        {
            collision.gameObject.SetActive(false);
        }
        if (collision.gameObject.CompareTag("Barrier"))
        {
            gameObject.SetActive(false);
        }
       

        gameObject.SetActive(false);

     //   Debug.Log("Bullet hit: " + collision.gameObject.name);

    }


}