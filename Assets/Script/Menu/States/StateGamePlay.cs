using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateGamePlay : GameState {

	private bool m_isPaused = false;
	// private float m_gameTime = 45f;

	public StateGamePlay(GameManager gm):base(gm) { }

	public override void Enter() {

	}

	public override void Execute() {
		
		if(Input.GetKeyDown(KeyCode.Escape)) {
			if(m_isPaused) {
				ResumeGameMode();
			} else {
				PauseGameMode();
			}
		}
	}

	public override void Exit(){

	}

	private void ResumeGameMode() {
		Time.timeScale = 1.0f;
		m_isPaused = false;
	}

	private void PauseGameMode() {
		Time.timeScale = 0.0f;
		m_isPaused = true;
	}
}
