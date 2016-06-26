using UnityEngine;
using System.Collections;

public class RhythmButtonHit : MonoBehaviour {

	public float min, max;
	public float maxForScore;
	public float subtractWhithEarlyPress;
	public float speed;
	public float currentValue;

	public float pressCount;


	[HideInInspector]
	public float timeInMinimum;


	// Use this for initialization
	void Start () {
		currentValue = max;
		pressCount = 0;
	}

	// Update is called once per frame
	void Update () {
		UpdateValue ();
	}



	void UpdateValue() {

		currentValue = Mathf.Max (min, currentValue - (Time.deltaTime * speed));

		if (Input.GetKeyDown (KeyCode.Space)) {
			pressCount++;
			if (currentValue > maxForScore) {
				//Subtract points;
			}
			currentValue = max;
		}


		if (currentValue == min) {
			timeInMinimum += Time.deltaTime;
		} else {
			timeInMinimum = 0;
		}
	}
}
