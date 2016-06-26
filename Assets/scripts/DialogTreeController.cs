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
		situationNumber = 0; //situacao inicial
	}
	
	// Update is called once per frame
	void Update () {
        if (situationNumber == 0) {
            if (Input.GetKeyDown(KeyCode.LeftArrow)) {
                situation.text = "A pessoa está respirando?";
                situationNumber = 1; 
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow)){
                situation.text = "A pessoa possui algo na boca?";
                situationNumber = 3;
            }
        }
        else if (situationNumber == 1) {
            if (Input.GetKeyDown(KeyCode.RightArrow)) {
                situation.text = "Faça massagem cardiaca";
                //SceneManager.LoadScene("MinigameMassagem");
                situationNumber = 2;
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow)) {
                situation.text = "Vire a pessoa de lado";
                //SceneManager.LoadScene("MinigameVira");
            }
       }
       else if (situationNumber == 3) {
            if (Input.GetKeyDown(KeyCode.LeftArrow)) {
                situation.text = "Tire essa parada da boca da pessoa";
                //SceneManager.LoadScene("MinigameTiraBoca");
                situationNumber = 4;
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow)) {
                situation.text = "Verifique a respiração";
                situationNumber = 0;
            }
        }
	}
}
