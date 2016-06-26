using UnityEngine;
using System.Collections;

public class RhythmButtonHit : MonoBehaviour {

	public float min, max;
	public float maxForScore;
	public float speed;

	public float subtractPointsWhithEarlyPress;
	public float numPointsToLoseWhenLate;

	public float minTimeForPointLoosing;
	private float lastPointsLost;

	public float currentValue;
	public float pressCount;



	// Use this for initialization
	void Start () {
		currentValue = max;
		pressCount = 0;
		lastPointsLost = -minTimeForPointLoosing;
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
				PointsManager.points -= subtractPointsWhithEarlyPress;
			}
			currentValue = max;
		}


		if (currentValue == min && Time.timeSinceLevelLoad > lastPointsLost + minTimeForPointLoosing) {
			minTimeForPointLoosing = Time.timeSinceLevelLoad;
			PointsManager.points -= numPointsToLoseWhenLate;
		}
	}
}
