using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class LB_Button : MonoBehaviour {

    protected LB_InputInfo inputInfo;
    protected Button button;

    private void Start()
    {
        Setup();
    }

    public virtual void Setup()
    {
        button = GetComponent<Button>();
        AddActionToButton(EventTriggerType.PointerDown, OnTouchDown);
        AddActionToButton(EventTriggerType.PointerUp, OnTouchUp);
    }

    public void AddActionToButton(EventTriggerType eventTriggerType, Action action)
    {
        EventTrigger trigger = gameObject.AddComponent<EventTrigger>();
        var entry = new EventTrigger.Entry
        {
            eventID = eventTriggerType
        };
        entry.callback.AddListener((e) => { action(); });
        trigger.triggers.Add(entry);
    }

    public virtual void OnTouchDown()
    {

    }

    public virtual void OnTouchUp()
    {

    }
}
