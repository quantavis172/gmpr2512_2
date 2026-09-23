using System.Runtime.CompilerServices;
using UnityEngine;

public class SquareScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] SpriteRenderer rend;
    [SerializeField] float delayTime;

    float timeStamp; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeStamp + delayTime && rend.color == Color.white)
        {
            rend.color = Color.white;
        }



    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("changed");
        timeStamp = Time.time;
        rend.color = Color.red;

        Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();
        GetComponent<BoxCollider2D>().enabled = false;
    }
}
