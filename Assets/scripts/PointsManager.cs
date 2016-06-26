using UnityEngine;
using System.Collections;

public class PointsManager : MonoBehaviour {


	public static float points;

	public static float initialPoints;
	public bool resetOnSceneLoad;


	// Use this for initialization
	void Start () {
		if (resetOnSceneLoad)
			points = initialPoints;
	}
	
	// Update is called once per frame
	void Update () {
		if (points <= 0) {
			//GAME OVER
		}
	}
}
