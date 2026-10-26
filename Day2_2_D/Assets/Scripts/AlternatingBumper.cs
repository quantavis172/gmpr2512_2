using UnityEngine;

public class AlternatingBumper : MonoBehaviour
{
    [SerializeField] CircleBumper bumperOne;
    [SerializeField] CircleBumper bumperTwo;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bumperOne.isActive = true;
        bumperTwo.isActive = false;

        bumperOne.GetComponent<SpriteRenderer>().color = Color.green;
        bumperTwo.GetComponent<SpriteRenderer>().color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        bumperOne.isActive = !bumperOne.isActive;
        bumperTwo.isActive = !bumperTwo.isActive;

        if (bumperOne.isActive)
        {
            bumperOne.GetComponent<SpriteRenderer>().color = Color.green;
            bumperTwo.GetComponent<SpriteRenderer>().color = Color.red;
        }
        else
        {
            bumperOne.GetComponent<SpriteRenderer>().color = Color.red;
            bumperTwo.GetComponent<SpriteRenderer>().color = Color.green;
        }
    }
}