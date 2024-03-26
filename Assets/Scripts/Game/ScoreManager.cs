using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance { get; private set; }

    public Text scoreTableText;
    public Text scoreText;
    public Text highScoreText;


    
    private void OnEnable()
    {
        PlayerManager.OnPLayerDied += PlayerManager_OnPLayerDied;
    }
    private void OnDisable()
    {
        PlayerManager.OnPLayerDied -= PlayerManager_OnPLayerDied;
    }

    private void PlayerManager_OnPLayerDied()
    {
        ShowScore();
        SetHighScore();
    }

    private void ShowScore()
    {
        scoreText.text = "Puntos: " + DataManager.Score.ToString();
    }

    private void SetHighScore()
    {
        if (DataManager.Score > DataManager.HighScore)
        {
            DataManager.HighScore = DataManager.Score;
            highScoreText.text = "Nuevo RECORD: " + DataManager.HighScore;

            PlayerPrefs.SetInt("highScore", DataManager.HighScore);
           
        }
        else
            highScoreText.text = "Record: " + DataManager.HighScore;
           

    }

    private void Awake()
    {
        Instance = this;
    }

   private void Start()
   {
               
       DataManager.HighScore = PlayerPrefs.GetInt("highScore", DataManager.HighScore);
       DataManager.Score = 0;
   
       
   }



    

   
   

   

}
