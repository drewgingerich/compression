﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BallController {

	public abstract BallController CheckTransitions();
	public virtual void Update() { }
	public virtual void Enter() { }
	public virtual void Exit() {}
}
