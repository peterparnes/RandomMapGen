using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour {

	public float speed = 4f;

	private Vector3 startPosition; 
	private bool moving; 

	void FixedUpdate() {
		if (Input.GetMouseButtonDown (1)) {
			startPosition = Input.mousePosition;
			moving = true; 
		}

		if (Input.GetMouseButtonUp (1) && moving) {
			moving = false;
		}

		if (moving) {
			Vector3 pos = Camera.main.ScreenToViewportPoint (Input.mousePosition - startPosition);
			Vector3 move = new Vector3 (pos.x * speed, pos.y * speed, 0);
			transform.Translate (move, Space.Self);
		}
	}
}
