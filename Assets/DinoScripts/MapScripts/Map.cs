using UnityEngine;
using System.Collections;

public class Map : MonoBehaviour
{
	public GameObject[,] cells;
	public GameObject cellObject;
	// Use this for initialization
	void Start ()
	{
		LoadCells (10, 10);
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	private void LoadCells(int row, int columns) {
		cells = new GameObject[row,columns];
		for (int i = 0; i < row; i++) {
			for (int j = 0; j < columns; j++) {
				cells[i,j] = GameObject.Instantiate (cellObject,new Vector3(j, i),new Quaternion(0,0,0,0), this.gameObject.transform);
			}
		}
	}
}

