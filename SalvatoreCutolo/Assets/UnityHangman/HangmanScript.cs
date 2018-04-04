using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HangmanScript : MonoBehaviour {

	
	
	string palabra;
    string palabraEscondida

    public Text outputText;
    public Input

    // Use this for initialization
	void Start () {
		foreach (char c in palabra) {
			palabraEscondida += "*";
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (outputText.text != palabraEscondida) {
		    outputText.text = palabraEscondida;
    }
    if (Input.GetKeyDown (KeyCode.Return)) {
    	char letra = inputText.text.Substring(0, 1);

}
