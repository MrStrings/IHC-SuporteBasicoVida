using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class Blinking : MonoBehaviour {

	public enum State {Low, High};

	public float timeLow, timeHigh;
	public Text text; 

	State currentState;
	float timeOfLastChange;

	// Use this for initialization
	void Start () {
		timeOfLastChange = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (currentState == State.High) {
			if (Time.timeSinceLevelLoad > timeOfLastChange + timeHigh) {
				currentState = State.Low;
				timeOfLastChange = Time.timeSinceLevelLoad;
				timeOfLastChange = Mathf.Round (timeOfLastChange * 2) / 2;
			}
			text.enabled = true;
		} else if (currentState == State.Low) {
			if (Time.timeSinceLevelLoad > timeOfLastChange + timeLow) {
				currentState = State.High;
				timeOfLastChange = Time.timeSinceLevelLoad;
				timeOfLastChange = Mathf.Round (timeOfLastChange * 2) / 2;
			}
			text.enabled = false;
		}

	}
}
