﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InputControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Escape")) {
            
            if (SceneManager.GetActiveScene().name.Contains("credits"))
            {
                Application.Quit();
            }
            else
            {
                SceneManager.LoadScene("credits");
            }
        }
	}
}
