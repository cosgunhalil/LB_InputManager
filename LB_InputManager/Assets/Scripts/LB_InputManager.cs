using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LB_InputManager : MonoBehaviour {

    private static LB_InputManager instance;
    public static LB_InputManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = (LB_InputManager)FindObjectOfType(typeof(LB_InputManager));
            }

            return instance;
        }
    }

    public delegate void InputGettedDelegate(LB_InputInfo inputInfo);
    public event InputGettedDelegate InputGettedEvent;

    public void SendInput(LB_InputInfo inputInfo)
    {
        if (InputGettedEvent != null)
        {
            InputGettedEvent(inputInfo);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            SendInput(new LB_InputInfo(ButtonType.button1, InputType.touchDown));
        }
    }
}
