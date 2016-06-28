using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MinigameController : MonoBehaviour {

	public GameObject breathButton;
	public float numberOfPressesForBreath, numberOfBreathsBeforeSceneChange, hitWindow = 1;



	RhythmButtonHit button;

	float breathCount;
	float timeActivateBreathButton;


	// Use this for initialization
	void Start () {
		button = GetComponent<RhythmButtonHit> ();
		breathButton.SetActive (false);

		breathCount = 0;
	}
	
	// Update is called once per frame
	void Update () {
		FrequencyControl ();
	}

	void FrequencyControl() {
		if (breathCount == 3) {
			SceneManager.LoadScene ("Win!");
		} else if (button.pressCount == numberOfPressesForBreath && !breathButton.activeInHierarchy) {
			breathButton.SetActive (true);
			button.enabled = false;
			timeActivateBreathButton = Time.timeSinceLevelLoad;
		}

		if (breathButton.activeInHierarchy) {
			if (Input.GetMouseButtonDown (0)) {
				Vector2 mousePos = (Vector2)Camera.main.ScreenToWorldPoint (Input.mousePosition);
				Collider2D hit = Physics2D.OverlapPoint (mousePos);

				if (hit && hit.gameObject == breathButton) {
					breathButton.SetActive (false);
					button.enabled = true;
					button.pressCount = 0;
					breathCount++;
				}
			}

			if (Time.timeSinceLevelLoad > timeActivateBreathButton + hitWindow && breathButton.activeInHierarchy) {
				button.pressCount = 0;
				PointsManager.points--;
			}
		}
	}
}
