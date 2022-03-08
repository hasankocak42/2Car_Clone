

using UnityEngine;
using System.Collections;

public class RestartButton : MonoBehaviour {

    public void OnClickRestartButton()
    {
        Managers.Game.SetState(typeof(GamePlayState));
        Managers.UI.inGameUI.gameOverPopUp.SetActive(false);
        Managers.Spawner.ClearObstacles();       
    }
}
