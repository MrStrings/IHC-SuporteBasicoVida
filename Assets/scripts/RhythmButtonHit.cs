using UnityEngine;
using System.Collections;

public class RhythmButtonHit : MonoBehaviour {

	public float min, max;
	public float speed;
	public float minimumForPontuation;
	public float currentValue;

	[HideInInspector]
	public float timeInMinimum;


	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		UpdateValue ();
	}



	void UpdateValue() {

		currentValue = Mathf.Max (min, currentValue - (Time.deltaTime * speed));

		if (Input.GetKeyDown (KeyCode.Space)) {
			currentValue = max;
		}


		if (currentValue == min) {
			timeInMinimum += Time.deltaTime;
		} else {
			timeInMinimum = 0;
		}
	}
}
