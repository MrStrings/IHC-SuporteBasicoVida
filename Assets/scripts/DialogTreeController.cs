using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogTreeController : MonoBehaviour {
	
	public Text situation;
	public Text[] choice;

	float situationNumber = 0;
	float previousSituation;
	string previousText;

	// Use this for initialization
	void Start () {
		situation.text = "A pessoa está consciente?";
		choice [0].text = "Sim";
		choice [1].text = "Não";
		situationNumber = 0; //situacao inicial
	}
	
	// Update is called once per frame
	void Update () {
		if (situationNumber == 0) {
			if (Input.GetKeyDown (KeyCode.LeftArrow)) {
				previousSituation = 0;
				previousText = situation.text;
				situation.text = "Você tem certeza?";
				situationNumber = 4;
			} else if (Input.GetKeyDown (KeyCode.RightArrow)) {
				situation.text = "A pessoa possui algo na boca?";
				situationNumber = 3;
			}
		} else if (situationNumber == 1) {
			if (Input.GetKeyDown (KeyCode.RightArrow)) {
				situation.text = "Faça massagem cardíaca!";
				Invoke ("LoadScene", 2);
				situationNumber = 2;
			} else if (Input.GetKeyDown (KeyCode.LeftArrow)) {
				previousSituation = 1;
				previousText = situation.text;
				situation.text = "Você tem certeza?";
				situationNumber = 4;
			}
		} else if (situationNumber == 3) {
			if (Input.GetKeyDown (KeyCode.LeftArrow)) {
				previousSituation = 3;
				previousText = situation.text;
				situation.text = "Você tem certeza?";
				situationNumber = 4;
			} else if (Input.GetKeyDown (KeyCode.RightArrow)) {
				situation.text = "A pessoa está respirando?";
				situationNumber = 1;
			}
		} else if (situationNumber == 4) {
			if (Input.GetKeyDown (KeyCode.LeftArrow)) {
				SceneManager.LoadScene ("GameOver");
			} else if (Input.GetKeyDown (KeyCode.RightArrow)) {
				situation.text = previousText;
				situationNumber = previousSituation;
			}
		}
	}


	void LoadScene() {
		SceneManager.LoadScene ("MinigameMassagem");
	}
}
