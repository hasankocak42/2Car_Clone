
using UnityEngine;
using System.Collections;

public enum InputMethod
{
    KeyboardInput,
    MouseInput,
    TouchInput
}

public class PlayerInputManager : MonoBehaviour
{
    public bool isActive;
    public InputMethod inputType = InputMethod.KeyboardInput;

    void Update()
    {
        /*if (isActive)
        {
            if (inputType == InputMethod.KeyboardInput)
                KeyboardInput();
            else if (inputType == InputMethod.TouchInput)
                TouchInput();
            else if (inputType == InputMethod.MouseInput)
                MouseInput();
        }*/
        if(isActive)
        {
            foreach (Touch touch in Input.touches)
            {
                if (touch.phase == TouchPhase.Ended)
                {
                    if (touch.position.x < Screen.width / 2)
                        Managers.Game.red.ChangeLane();
                    else
                        Managers.Game.blue.ChangeLane();
                }
            }
        }
    }

    #region KEYBOARD
    void KeyboardInput()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
            Managers.Game.red.ChangeLane();
        else if (Input.GetKeyDown(KeyCode.RightArrow))
            Managers.Game.blue.ChangeLane();

    }
    #endregion

    #region TOUCH
    void TouchInput()
    {
        foreach (Touch touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Ended)
            {
                if (touch.position.x < Screen.width / 2)
                    Managers.Game.red.ChangeLane();
                else
                    Managers.Game.blue.ChangeLane();
            }
        }
    }
    #endregion

    #region MOUSE
    void MouseInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (Input.mousePosition.x < Screen.width / 2)
                Managers.Game.red.ChangeLane();
            else
                Managers.Game.blue.ChangeLane();
        }

    }
    #endregion

}
