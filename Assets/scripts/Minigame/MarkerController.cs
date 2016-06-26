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
		position = transform.position;
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
		if (state != State.InMinimumSize) {
			position = transform.position;
			state = State.InMinimumSize;
		}
			
		transform.position = position + (Vector3)Random.insideUnitCircle * 0.05f;
		sprite.color = Color.red;
	}


	void NotInMinimumSizeBehavior () {
		if (state != State.NotInMinimumSize) {
			transform.position = position;
			state = State.NotInMinimumSize;
		}
		sprite.color = Color.white;
	}

	void InCorrectSizeBehavior () {
		if (state != State.InCorrectSize) {
			transform.position = position;
			state = State.InCorrectSize;
		}
		sprite.color = Color.green;
	}
}
