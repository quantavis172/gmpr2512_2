using UnityEngine;

public class AlternatingBumper : MonoBehaviour
{
    [SerializeField] GameObject bumperOne;
    [SerializeField] GameObject bumperTwo;

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
        if (bumperOne.activeSelf)
        {
            bumperOne.SetActive(false);
            bumperTwo.SetActive(true);
        }
        else
        {
            bumperOne.SetActive(true);
            bumperTwo.SetActive(false);
        }
    }
}