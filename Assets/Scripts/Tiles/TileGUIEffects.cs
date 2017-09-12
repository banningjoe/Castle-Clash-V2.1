using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TileGUIEffects : MonoBehaviour {
	public static GameObject selectedTile = null;
	public Material originalColor;
	public Material fieldTint;
	public Text text;

	void OnMouseOver()
	{
		MouseOverChangeColors();
		MouseOverChangeUI();
		MouseClick();
 	}

 	void OnMouseExit()
 	{
		MouseExitChangeColors();
 	}

 	void MouseOverChangeColors(){
		Renderer rend = gameObject.GetComponent<Renderer>();
		rend.material.color = Color.black;
		TileInfoHolder info = gameObject.GetComponent<TileInfoHolder>();
		for (int i = 0; i < info.neighbours.Count; i++) {
			rend = info.neighbours[i].GetComponent<Renderer>();
			rend.material = fieldTint;
		}
 		rend.material = fieldTint;
 	}

 	void MouseExitChangeColors(){
		Renderer rend = gameObject.GetComponent<Renderer>();
 		rend.material = originalColor;
		TileInfoHolder info = gameObject.GetComponent<TileInfoHolder>();
		for (int i = 0; i < info.neighbours.Count; i++) {
			rend = info.neighbours[i].GetComponent<Renderer>();
			TileGUIEffects color = info.neighbours[i].GetComponent<TileGUIEffects>();
			rend.material = color.originalColor;
		}
 	}

 	void MouseOverChangeUI(){
		TileInfoHolder info = gameObject.GetComponent<TileInfoHolder>();
 		UITextManager.currentHoverUnits = string.Format("Villagers: {0}| Warriors: {1}",info.villagers.Count,info.warriors.Count);
 	}

 	void MouseClick(){
		if (Input.GetMouseButtonDown(0)){
 			selectedTile = gameObject;
 			Debug.Log("Selected: " + selectedTile.name);
		}
		else if (Input.GetMouseButtonDown(1)) {
			TileMethods methods = GetComponent<TileMethods>();
			methods.MoveUnits(selectedTile);

		}
 	}


}
