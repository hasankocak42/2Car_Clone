

using UnityEngine;
using System.Collections;

public class HomeButton : MonoBehaviour {

    public void OnClickHomeButton()
    {
        Managers.Audio.PlayUIClick();
        Managers.Game.SetState(typeof(MenuState));
    }
}
