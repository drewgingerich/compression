﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpactController : BallController {

	float maxStickyTime = 0.75f;
	float friction = 2f;

	public override BallController CheckTransitions(BallState state, Rigidbody2D rb2d) {
		if (CheckAirbornTransition(state))
			return new AirbornController();
		if (CheckReboundTransition(state))
			return new ReboundController();
		if (CheckGroundedTransition(state))
			return new GroundedController();
		return null;
	}

	public override void Enter(BallState state, Rigidbody2D rb2d) {
		state.stateName.Value = StateName.Impact;
		state.gravityRatio.Value = 0f;
	}

	public override void Exit(BallState state, Rigidbody2D rb2d) {
		state.previousState.Value = StateName.Impact;
	}

	public override void Update(BallState state, Rigidbody2D rb2d) {
		rb2d.AddForce(rb2d.velocity * -friction);
	}
	
	bool CheckAirbornTransition(BallState state) {
		return !state.grounded.Value ? true : false;
	}

	bool CheckReboundTransition(BallState state) {
		return state.inputDirection.Value != Vector2.zero ? true : false;
	}

	bool CheckGroundedTransition(BallState state) {
		return state.timeInState.Value >= maxStickyTime ? true : false;
	}
}

