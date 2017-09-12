using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIToggleManager : MonoBehaviour {

	Text t;
	Toggle togg;

	public void Toggle(){
		t = transform.Find("Label").GetComponent<Text>();
		togg = GetComponent<Toggle>();
		if (t.text == "Moving Villagers") {
			t.text = "Moving Warriors";
		}
		else {
			t.text = "Moving Villagers";
		}
	}
}
