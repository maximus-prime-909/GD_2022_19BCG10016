using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI text;
    public void StartGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void ScoreUpdate(int score)
    {
        text.text = "Score: "+ score ;
    }
    private void Update()
    {
        int score = PlayerController.ScoreFetcher();
        ScoreUpdate(score);
    }
}