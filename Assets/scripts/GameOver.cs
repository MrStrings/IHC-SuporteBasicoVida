using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

	public Text text;
	public AudioClip clip;
	public float timeOfStart;


	private bool didAppear = false;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (!didAppear && Time.timeSinceLevelLoad > timeOfStart) {
			text.gameObject.SetActive (true);
			if (clip)
				AudioSource.PlayClipAtPoint (clip, new Vector3 (0, 0, -10));
			didAppear = true;
		}


		if (Time.timeSinceLevelLoad > timeOfStart && Input.anyKeyDown) {
			SceneManager.LoadScene ("DecisionTree");
		}

	}
}
