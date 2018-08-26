using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enclosure : MonoBehaviour {

	public int Integrity; //0-5

	List<Employee> Employees;
	List<Dinosaur> Dinosaurs;
	private Grid grid;
	bool built = false;
	bool buildable = false;
	/// <summary>
	/// Initializes a new instance of the <see cref="Enclosure"/> class.
	/// </summary>
	public Enclosure() {
		Integrity = 5;
		Dinosaurs = new List<Dinosaur> ();
		Employees = new List<Employee> ();
	}

	public Enclosure(int _integrity, List<Employee> _employees, List<Dinosaur> _dinosaurs) {
		Integrity = _integrity;
		Employees = _employees;
		Dinosaurs = _dinosaurs;
	}

	/// <summary>
	/// Updates the enclosure.
	/// </summary>
	public void updateEnclosure() {

		foreach (Dinosaur d in Dinosaurs) {
		
		
		}
	}

	/// <summary>
	/// Feeding dinosaurs
	/// </summary>
	public void feed() {

	}

	/// <summary>
	/// Playing with dinosaurs
	/// </summary>
	public void play() {

	}

	void Start ()
	{
		grid = GameObject.FindGameObjectWithTag ("Grid").GetComponent (typeof(Grid)) as Grid;
		Debug.Log (grid);
	}

	// Update is called once per frame
	void Update ()
	{
		if (!built) {

			var v3 = Input.mousePosition;
			v3.z = 10.0f;
			gameObject.transform.position = Camera.main.ScreenToWorldPoint (v3);

			if (Input.GetMouseButtonDown (0)) {
				Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
				RaycastHit2D hitInfo = Physics2D.Raycast (new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, 
					Camera.main.ScreenToWorldPoint(Input.mousePosition).y), Vector2.zero, 0f);
				if (hitInfo.collider != null) {
					Debug.Log (hitInfo.point);
					Build (hitInfo.point);
				}
			}
		}
	}

	public void Build (Vector2 nearPoint) {
		if (buildable) {
			Debug.Log ("nearPoint: " + nearPoint);
			var finalPoint = grid.GetNearestPointOnGrid (nearPoint);

			built = true;
			gameObject.transform.position = finalPoint;
		}
	}

	void OnTriggerStay2D(Collider2D collider) {
		var cell = collider.gameObject.GetComponent ("Cell") as Cell;
		if (cell.occupant != null) {
			buildable = false;
		} else {
			buildable = true;
		}

		if (!built) {
			if (!buildable) {
				//change color red
			} else {
				//change color to normal
			}
		}
	}
}
