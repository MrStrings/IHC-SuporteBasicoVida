using UnityEngine;
using System.Collections;

public class CheckTouch : MonoBehaviour {

	public enum State {Normal, Hit}

	public State state;

	// Use this for initialization
	void Start () {
		state = State.Normal;
	}
	
	// Update is called once per frame
	void Update () {
		if (state == State.Normal) {
			if (Input.GetMouseButtonDown (0)) {
				Vector2 mousePos = (Vector2)Camera.main.ScreenToWorldPoint (Input.mousePosition);
				Collider2D hit = Physics2D.OverlapPoint (mousePos);

				if (hit && hit.gameObject == gameObject) {
					GotHit ();
				}
			}
		} else if (state == State.Hit) {
			transform.localScale = transform.localScale * 0.9f;
			if (transform.localScale.x < 0.2f && gameObject)
				Destroy (gameObject);
		}
	}


	void GotHit() {
		state = State.Hit;
	}
}
