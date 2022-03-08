

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using DG.Tweening;

public class MainMenu : MonoBehaviour
{
    public Text CarsLogo;
    public GameObject restartButton;

    void OnEnable()
	{
        CarsLogo.enabled = true;
    }

	void OnDisable()
	{
		CarsLogo.enabled = false;
    }

    public void MainMenuStartAnimation()
    {
        GetComponent<RectTransform>().DOAnchorPosY(0, 0.3f, true);
        CarsLogo.GetComponent<RectTransform>().DOAnchorPosY(450, 0.3f, true);
    }

    public void MainMenuEndAnimation()
    {
        GetComponent<RectTransform>().DOAnchorPosY(-1450, 0.3f, true);
        CarsLogo.GetComponent<RectTransform>().DOAnchorPosY(1350, 0.3f, true);
    }
}

