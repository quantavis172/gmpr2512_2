using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;



public class SwitchToScene02 : MonoBehaviour
{

    Button _scoreButton;
    //public UnityEngine.UI.Button changeButton;
    //public int number;



    private void OnEnable()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;
        _scoreButton = root.Q<Button>("ChangeToScene02");
        

        if(_scoreButton != null)
        {
            _scoreButton.clicked += IncrementScore;
        }







    }
    private void OnDisable()
    {
        if(_scoreButton != null)
        {
            _scoreButton.clicked -= IncrementScore;
        }
    }

    void IncrementScore()
    {
        Debug.Log("Button Clicked");
        SceneManager.LoadScene("Level01");
    }



}
