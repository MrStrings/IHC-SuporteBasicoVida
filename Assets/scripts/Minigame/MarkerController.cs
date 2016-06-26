using UnityEngine;
using System.Collections;

public class MarkerController : MonoBehaviour {

	public enum State {InMinimumSize, NotInMinimumSize, InCorrectSize}

	public State state;

	public RhythmButtonHit sizeController;

	private SpriteRenderer sprite;

	private Vector3 position;

	// Use this for initialization
	void Start () {
		sprite = GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		transform.localScale = Vector3.right * sizeController.currentValue + Vector3.up * sizeController.currentValue;

		if (sizeController.currentValue == sizeController.min) {
			InMinimumSizeBehavior ();
		} else if (sizeController.currentValue < sizeController.maxForScore) {
			InCorrectSizeBehavior ();
		} else {
			NotInMinimumSizeBehavior ();
		}
	}


	void InMinimumSizeBehavior () {
		sprite.color = Color.red;
	}


	void NotInMinimumSizeBehavior () {
		sprite.color = Color.white;
	}

	void InCorrectSizeBehavior () {
		sprite.color = Color.green;
	}
}
