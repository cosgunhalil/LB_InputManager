using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LB_InputInfo {

    public InputType inputType;
    public ButtonType button;
    public object[] info;

    public LB_InputInfo(ButtonType button, InputType inputType, object[] info = null)
    {
        this.button = button;
        this.inputType = inputType;
        this.info = info;
    }
}
