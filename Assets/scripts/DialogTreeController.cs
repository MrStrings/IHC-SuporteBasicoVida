using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogTreeController : MonoBehaviour {
	
	public Text situation;
	public Text[] choice;

	float situationNumber = 0;


	// Use this for initialization
	void Start () {
		situation.text = "A pessoa está consciente?";
		choice [0].text = "Sim";
		choice [1].text = "Não";
		situationNumber = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (situationNumber == 0) {
			if (Input.GetKeyDown (KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow)) {
				situationNumber = 1;
				situation.text = "A pessoa está respirando?";
			}

		} else if (situationNumber == 1) {
			if (Input.GetKeyDown (KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow)) {
				SceneManager.LoadScene ("MinigameMassagem");
			}
		}
	}
}
