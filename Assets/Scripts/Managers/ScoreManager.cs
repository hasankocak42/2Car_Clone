

using UnityEngine;
using System.Collections;



public class ScoreManager : MonoBehaviour {

	public int currentScore=0;
	public int highScore;

    void Awake()
    {
        if (Managers.Game.stats.highScore != 0)
        {
            highScore = Managers.Game.stats.highScore;
        }

        else
        {
            highScore = 0;
        }
    }

	public void OnScore(int scoreIncreaseAmount)
	{	
		currentScore += scoreIncreaseAmount;
        Managers.UI.inGameUI.UpdateScoreUI();
        Managers.Game.stats.totalScore += scoreIncreaseAmount;
    }

    public void CheckHighScore()
    {
        if (highScore < currentScore)
        {
            highScore = currentScore;
        }
    }

    public void ResetScore()
    {
        currentScore = 0;
        highScore = Managers.Game.stats.highScore;
        Managers.UI.inGameUI.UpdateScoreUI();
    }

}
