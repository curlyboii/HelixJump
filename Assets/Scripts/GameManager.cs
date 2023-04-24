using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    private int score;
    public Text textScore;
    public static GameManager instance;
    public GameObject gameplayUI;
    public GameObject menuUI;

    bool firstInput = true;
    public bool gameStarted;

    private void Awake()
    {
        if (instance == null)
        { 
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameStarted)
        {
            if (Input.GetMouseButtonDown(0))
            {
                GameStart();
            }
        }

    }

    public void GameScorePlus(int ringScore)
    {
        score += ringScore;
        textScore.text = score.ToString();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void GameStart()
    { 
    
        gameplayUI.SetActive(true);
        menuUI.SetActive(false);

    }

    public void GameOver()
    {

        gameplayUI.SetActive(false);

    }

    void CheckInput()
    {

        if(!firstInput)
        {
            firstInput = false;
            return;

        }
        if (Input.GetMouseButtonDown(0))
        { 
        

        
        }

    }

}
