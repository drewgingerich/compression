﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class InputUtility  {

	public static Vector2 GetInputDirection () {
		Vector2 inputVector = new Vector2 (Input.GetAxis ("Horizontal"), Input.GetAxis ("Vertical"));
		if (inputVector.magnitude == 0)
			return Vector2.zero;
		else
			return inputVector.normalized;
	}

}
