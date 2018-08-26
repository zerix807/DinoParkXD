using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIHandlers : MonoBehaviour {

	public List<GameObject> panels; 
	public Dictionary<string, GameObject> panelDictionary; 

	public GameObject currentMenu;
	public GameObject enclosureParent;
	// Use this for initialization
	void Start () {
		panelDictionary = new Dictionary<string, GameObject> ();
		foreach (GameObject g in panels) {
			panelDictionary.Add (g.name, g);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	#region Menu Functions
	public void menuHandler(string name) {
		currentMenu = activateMenu (name);
	}

	public GameObject activateMenu(string name) {
		currentMenu.SetActive (false);
		GameObject panel = panelDictionary [name];
		panel.SetActive (true);
		return panel;
	}
	#endregion

	#region Drag and Drop
	public void CreateMapObject(string name) {
		var v3 = Input.mousePosition;
		v3.z = 10.0f;
		GameObject g = Instantiate(Resources.Load ("Prefabs/" + name, typeof(GameObject)), Camera.main.ScreenToWorldPoint(v3), Quaternion.identity, enclosureParent.transform) as GameObject;
	}
	#endregion
}
