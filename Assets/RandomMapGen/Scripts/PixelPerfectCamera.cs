﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PixelPerfectCamera : MonoBehaviour {

	public static float pixelToUnits = 1f;
	public static float scale = 1f;

	public Vector2 nativeResolution = new Vector2(160,144);

	void Awake() {
		var camera = GetComponent<Camera>();
		if(camera.orthographic) {
			var dir = Screen.height;
			var res = nativeResolution.y;
			scale = dir / res;
			pixelToUnits *= scale;
			camera.orthographicSize = (dir / 2.0f) / pixelToUnits;
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
