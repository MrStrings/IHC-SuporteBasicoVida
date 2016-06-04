using UnityEngine;
using System.Collections;

public class RhythmButtonHit : MonoBehaviour {

	public enum State {Increasing, Decreasing};

	public float min, max;
	public float speed;
	public float min_correct, max_correct;
	public float currentValue;


	public State state = State.Decreasing;


	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		UpdateValue ();
	}



	void UpdateValue() {
		if (state == State.Decreasing) {
			if (currentValue < min) {
				state = State.Increasing;
			}

			currentValue -= (Time.deltaTime * speed);

		} else {
			if (currentValue > max) {
				state = State.Increasing;
			}

			currentValue += (Time.deltaTime * speed);
		}

	}
}
