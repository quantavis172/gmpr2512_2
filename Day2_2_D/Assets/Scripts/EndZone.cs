    using UnityEngine;

public class EndZone : MonoBehaviour
{


    [SerializeField] GameObject ballSpawn;
    Rigidbody2D ball;
    
    private void OnTriggerEnter(Collider2D collision)
    {

        ball = collision.gameObject.GetComponentInParent<Rigidbody2D>();
        

        if (ball != ball)
        {
            ball.linearVelocity = Vector3.zero;
            ball.gameObject.transform.position = ballSpawn.transform.position;
        }
    }





}
