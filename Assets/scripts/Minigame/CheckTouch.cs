using UnityEngine;
using System.Collections;

public class CheckTouch : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Vector2 mousePos = (Vector2) Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Collider2D hit = Physics2D.OverlapPoint(mousePos);
		}
	}
}
