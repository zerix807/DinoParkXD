using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour {

	[SerializeField]
	private float size = 1f;


	public Vector2 GetNearestPointOnGrid(Vector2 position)
	{
		Debug.Log ("Hello: " + position);
		position -= Vector3Extension.AsVector2(transform.position);
		int xCount = Mathf.RoundToInt (position.x / size);
		int yCount = Mathf.RoundToInt (position.y / size);

		Vector2 result = new Vector2 (
			                 (float)xCount * size,
			                 (float)yCount * size);
		result += Vector3Extension.AsVector2(transform.position);
		Debug.Log (result);
		return result;

	}

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnDrawGizmos()
	{
		Gizmos.color = Color.yellow;
		for (float x = 0; x < 10; x += size) {
			for (float y = 0; y < 10; y += size) {
				var point = GetNearestPointOnGrid(Vector3Extension.AsVector2(new Vector3(x,y,0f)));
				Gizmos.DrawSphere (point, 0.1f);
			}
		}
	}
}
