using UnityEngine;
using System.Collections;

public class Follower : MonoBehaviour {


	public Transform target;
	public float speed;
	public float minDistanceForFollowing = 1;
	public float minDistanceForPointLoosing = 4;

	public float numPointsToLose;
	public float minTimeForPointLoosing;


	private float lastPointsLost;
	private CheckTouch touch;

	// Use this for initialization
	void Start () {
		lastPointsLost = -minTimeForPointLoosing;
		touch = GetComponent<CheckTouch> ();
	}
	
	// Update is called once per frame
	void Update () {
		if ((target.transform.position - transform.position).magnitude >= minDistanceForFollowing) {
			transform.position = Vector2.MoveTowards (transform.position,
				target.transform.position, speed * Time.deltaTime);
		}

		//Loose points
		if ((target.transform.position - transform.position).magnitude <= minDistanceForPointLoosing &&
		    Time.timeSinceLevelLoad >= lastPointsLost + minTimeForPointLoosing &&
			touch.state == CheckTouch.State.Normal) {
			PointsManager.points -= numPointsToLose;
			lastPointsLost = Time.timeSinceLevelLoad;

		}



		if (target.transform.position.x < transform.position.x) {
			transform.localScale = new Vector3 (-Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
		} else {
			transform.localScale = new Vector3 (Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
		}
	}
}
