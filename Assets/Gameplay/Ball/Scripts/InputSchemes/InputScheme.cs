﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Input Scheme", menuName = "Input Scheme")]
public class InputScheme : ScriptableObject {

	public enum InputType { Keys, Joystick, Mouse, Tilt, Touch }

	public InputType inputType;

	[SerializeField] string horizontalAxisName;
	[SerializeField] string verticalAxisName;

	public Vector2 GetInputDirection() {
		float horizontalInput = Input.GetAxis(horizontalAxisName);
		float verticalInput = Input.GetAxis(verticalAxisName);
		return new Vector2(horizontalInput, verticalInput).normalized;
	}
}
