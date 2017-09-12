using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UITextManager : MonoBehaviour {

	public static string currentHoverUnits = "Villagers:  | Warriors:  ";

	Text text;

	void Awake(){
		text = GetComponent<Text>();
	}

	void Update(){
		text.text = currentHoverUnits;
	}
}
