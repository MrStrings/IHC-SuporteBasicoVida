using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class collider_controller : MonoBehaviour {
    public GameObject kenny;
    // Use this for initialization
    void Start () {
	    //nada a fazer aqui
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.anyKeyDown && !Input.GetMouseButtonDown(0)) {
			kenny.SetActive (false);
		}

		if (Input.GetMouseButtonDown (0)) {
			Vector2 mousePos = (Vector2)Camera.main.ScreenToWorldPoint (Input.mousePosition);
			Collider2D hit = Physics2D.OverlapPoint (mousePos);

			if (hit && hit.gameObject == gameObject) {
				kenny.SetActive (!kenny.activeInHierarchy);
			}
		}
    }
}
