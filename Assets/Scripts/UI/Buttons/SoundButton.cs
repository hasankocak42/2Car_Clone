
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SoundButton : MonoBehaviour {

    public Sprite on, off;

    public void TurnUpDownSound()
    {
        if (AudioListener.volume == 0)
        {
            GetComponent<Image>().sprite = on;
            Managers.Audio.PlayUIClick();
            AudioListener.volume = 1.0f;

        }

        else if (AudioListener.volume == 1.0f)
        {
            GetComponent<Image>().sprite = off;
            Managers.Audio.PlayUIClick();
            AudioListener.volume = 0f;
        }
    }
}
