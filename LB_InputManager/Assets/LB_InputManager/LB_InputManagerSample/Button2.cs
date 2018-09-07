using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button2 : LB_Button {

    public override void OnTouchDown()
    {
        LB_InputManager.Instance.SendInput(new LB_InputInfo(ButtonType.button2, InputType.touchDown));
    }

    public override void OnTouchUp()
    {
        LB_InputManager.Instance.SendInput(new LB_InputInfo(ButtonType.button2, InputType.touchUp));
    }
}
