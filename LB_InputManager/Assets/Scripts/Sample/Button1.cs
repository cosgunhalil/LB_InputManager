using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button1 : LB_Button {
    
    public override void OnTouchDown()
    {
        LB_InputManager.Instance.SendInput(new LB_InputInfo(ButtonType.button1, InputType.touchDown));
    }

    public override void OnTouchUp()
    {
        LB_InputManager.Instance.SendInput(new LB_InputInfo(ButtonType.button1, InputType.touchUp));
    }


}
