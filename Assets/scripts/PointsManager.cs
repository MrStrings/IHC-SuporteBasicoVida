using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PointsManager : MonoBehaviour {



	public static float points;
	public float points_local;

	public float initialPoints;
	public bool resetOnSceneLoad;

	public Text pointText;


	// Use this for initialization
	void Start () {
		if (resetOnSceneLoad)
			points = initialPoints;
	}
	
	// Update is called once per frame
	void Update () {
		points_local = points;
		if (points <= 0) {
			SceneManager.LoadScene ("GameOver");
		}

		ShowPoints ();
	}


	void ShowPoints() {
		if (pointText)
			pointText.text = "Pontos: " + points;
	}
}
