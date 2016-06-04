using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DialogTreeController : MonoBehaviour {

	public Text situation;
	public Text[] choice;


	// Use this for initialization
	void Start () {
		situation.text = "Me salva";
		choice [0].text = "Agora";
		choice [1].text = "Depois...";
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
