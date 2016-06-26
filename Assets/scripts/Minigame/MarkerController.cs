using UnityEngine;
using System.Collections;

public class MarkerController : MonoBehaviour {

	public RhythmButtonHit sizeController;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.localScale = Vector3.right * sizeController.currentValue + Vector3.up * sizeController.currentValue;

		if (sizeController.currentValue == sizeController.min)
			InMinimumSizeBehavior ();
			
	}


	void InMinimumSizeBehavior () {

	}
}
