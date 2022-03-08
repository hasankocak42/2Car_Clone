

using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class InGameUI : MonoBehaviour {

	public Text score;
    public GameObject gameOverPopUp;

    public void UpdateScoreUI()
	{
        score.text = Managers.Score.currentScore.ToString();
    }

    public void InGameUIStartAnimation()
    {
        score.rectTransform.DOAnchorPosY(-124, 1, true);
    }

    public void InGameUIEndAnimation()
    {
        score.rectTransform.DOAnchorPosY(-124 + 650, 0.2f, true);
    }


}
