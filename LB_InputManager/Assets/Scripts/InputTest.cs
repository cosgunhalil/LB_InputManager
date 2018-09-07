using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputTest : MonoBehaviour {

    private void Start()
    {
        LB_InputManager.Instance.InputGettedEvent += TouchDown;
    }

    public void TouchDown(LB_InputInfo info)
    {
        Debug.Log(info.button);
        Debug.Log(info.inputType);
        Debug.Log(info.info);
    }
}
