﻿using UnityEngine;
using System.Collections;
using UnuGames;

public class TestExample2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		UIMan.Instance.ShowDialog<UIExample2> ("Message", "Close", Color.green, "uiman-icon-1", false, 1000);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
