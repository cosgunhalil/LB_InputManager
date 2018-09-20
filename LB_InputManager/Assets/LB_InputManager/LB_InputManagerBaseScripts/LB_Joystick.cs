using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LB_Joystick : LB_Button
{
    public Canvas ContainerCanvas;
    public LB_JoystickKnob Knob;
    private RectTransform _joystickRect;
    private Vector2 _knobMovementLimits;

    private Vector2 _touchPosition;
    private bool _isPlayerTouchesTheJoystick;

    private Camera _camera;

    public override void Setup()
    {
        base.Setup();
        _camera = Camera.main;
        _joystickRect = GetComponent<RectTransform>();
        Knob.Init(_joystickRect);
    }

    public override void OnTouchDown()
    {
        _isPlayerTouchesTheJoystick = true;
    }

    public override void OnTouchUp()
    {
        _isPlayerTouchesTheJoystick = false;
        Knob.SetDefaultPosition();
    }

    private void Update()
    {
        if (_isPlayerTouchesTheJoystick)
        {
#if UNITY_EDITOR
            _touchPosition = Input.mousePosition;
#else
            _touchPosition = Input.GetTouch(0).position;
#endif
            Knob.SetPosition(_touchPosition);
        }
    }

}
