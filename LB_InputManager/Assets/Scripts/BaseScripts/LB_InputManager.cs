using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LB_InputManager {

    private static readonly LB_InputManager instance = new LB_InputManager();

    static LB_InputManager()
    {
        
    }

    private LB_InputManager()
    {
        
    }

    public static LB_InputManager Instance
    {
        get
        {
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
}
