using UnityEngine;

public class DropTargets : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] float resetDelay = 2f;

    private Collider2D targetCollider;
    private SpriteRenderer targetSprite;

  
    
    void Start()
    {
       
        targetCollider = GetComponent<Collider2D>();
        targetSprite = GetComponent<SpriteRenderer>();
   
    
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        targetSprite.enabled = false;
        targetCollider.enabled = false;

        Invoke("ResetTarget", resetDelay);
    }
    void ResetTarget()
    {
       
        targetSprite.enabled = true;
        targetCollider.enabled = true;
    
    
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
