using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enclosure {

	private int Integrity; //0-5
	private int Size;//0-4

	List<Employee> Employees;
	List<Dinosaur> Dinosaurs;

	/// <summary>
	/// Initializes a new instance of the <see cref="Enclosure"/> class.
	/// </summary>
	public Enclosure(int _size) {
		Size = _size;
		Integrity = 5;
		Dinosaurs = new List<Dinosaur> ();
		Employees = new List<Employee> ();
	}

	public Enclosure(int _integrity, int _size, List<Employee> _employees, List<Dinosaur> _dinosaurs) {
		Integrity = _integrity;
		Size = _size;
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



}
