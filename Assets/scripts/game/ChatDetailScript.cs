﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChatDetailScript : MonoBehaviour {

	public GameObject headerBar;
	public GameObject chatContent;
	public GameObject footerBar;

	private CharacterModel character;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ReceiveModel(CharacterModel characterModel) {
		character = characterModel;
	}
}
