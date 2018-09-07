using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LoggerObject : MonoBehaviour {

	// Use this for initialization
	void Start () {
        LB_InputManager.Instance.InputGettedEvent += InputGetted;
	}

    private void InputGetted(LB_InputInfo inputInfo)
    {
        Debug.Log(inputInfo.button + " / " +  inputInfo.inputType);
    }
}
