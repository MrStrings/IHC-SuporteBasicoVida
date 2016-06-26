using UnityEngine;
using System.Collections;

public class PointsManager : MonoBehaviour {



	public static float points;
	public float points_local;

	public float initialPoints;
	public bool resetOnSceneLoad;


	// Use this for initialization
	void Start () {
		if (resetOnSceneLoad)
			points = initialPoints;
	}
	
	// Update is called once per frame
	void Update () {
		points_local = points;
		if (points <= 0) {
			//GAME OVER
		}
	}
}
