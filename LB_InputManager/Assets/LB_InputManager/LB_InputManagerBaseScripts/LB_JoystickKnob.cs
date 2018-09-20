using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LB_JoystickKnob : MonoBehaviour {

    private RectTransform _knobRect;
    private float _movementLimit;

    public void Init(RectTransform containerRect)
    {
        _knobRect = GetComponent<RectTransform>();
        SetupMovementLimits(containerRect);
    }

    private void SetupMovementLimits(RectTransform containerRect)
    {
        var containerPosition = containerRect.anchoredPosition;
        var containerSize = containerRect.sizeDelta;

        _movementLimit = (containerPosition.x + containerSize.x / 2f) - _knobRect.sizeDelta.x / 2f;
    }

    public Vector2 GetPosition()
    {
        return _knobRect.position;
    }

    public void SetPosition(Vector2 position)
    {
        var knobPosition = FixTheTouchPosition(position);
        _knobRect.localPosition = knobPosition;
    }

    public void SetDefaultPosition()
    {
        _knobRect.localPosition = new Vector2(0, 0);
    }

    private Vector2 FixTheTouchPosition(Vector2 position)
    {
        float posX = position.x;
        float posY = position.y;

        var d = (Vector2)_knobRect.position - position;
        var n = d.normalized;
        var pos = n * _movementLimit;

        return pos;
    }
}
