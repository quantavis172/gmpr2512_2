using UnityEngine;

public class CircleBumper : MonoBehaviour
{
    [SerializeField]SpriteRenderer rend;
    
    
    [SerializeField] float delayTime;
    [SerializeField] float forceValue;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    float timeStamp;

    public bool isActive = true;
    void Start()
    {
        //delayTime = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeStamp + delayTime)
        {
            rend.color = Color.black;   
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!isActive)
        {
            return;
        }

        timeStamp = Time.time;
        rend.color = Color.white;

        //random color on collision
        rend.color = Random.ColorHSV();

        // Impulse force
        Vector2 direction = (collision.transform.position - transform.position).normalized;
        Vector2 impulse = direction * forceValue;

        Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();
        rb.AddForce(impulse * rb.mass, ForceMode2D.Impulse);
    }
}
