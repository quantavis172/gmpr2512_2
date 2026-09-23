using UnityEngine;

public class CircleBumper : MonoBehaviour
{
    [SerializeField]SpriteRenderer rend;
    
    
    [SerializeField] float delayTime;
    [SerializeField] float forceValue;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    float timeStamp;
    void Start()
    {
        //delayTime = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeStamp + delayTime && rend.color == Color.white)
        {
            rend.color = Color.black;
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
       
        Debug.Log("change");
        timeStamp = Time.time;
        rend.color = Color.green;

        Vector2 direction = (collision.transform.position - transform.position);

        Vector2 impulse = direction * forceValue;

        Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();

        

    }
}
