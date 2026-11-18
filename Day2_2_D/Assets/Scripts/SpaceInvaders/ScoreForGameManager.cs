using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;



public class ScoreForGameManager : MonoBehaviour
{

  
    //public UnityEngine.UI.Button changeButton;
    //public int number;


    private void Start()
    {
        if(SceneManager.GetActiveScene(.name)== "Scene01")
        {
            gameState = 0;
        }
    }



    [SerializeField] Button _scoreButton;
    [SerializeField] Label _scoreText;

    private void OnEnable()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;
        _scoreButton = root.Q<Button>("ScoreButton");
        _scoreText = root.Q<Label>("ScoreText");

        if (_scoreButton != null)
        {
            _scoreButton.clicked += IncrementScore;
        }







    }
    private void OnDisable()
    {
        if (_scoreButton != null)
        {
            _scoreButton.clicked -= IncrementScore;
        }
    }

    void IncrementScore()
    {
       


     gameState.score++;
   


        if (_scoreText != null)
        {
            _scoreText.value = gameState.score.ToString();
        }
 
    }
     void UpdateScore()
    {
        



    }



}
