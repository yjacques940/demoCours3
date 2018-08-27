﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {
    [SerializeField] GameObject gun;
    [SerializeField] Camera playerCamera;
    [SerializeField] GameObject player;
    //glisser les objects sur leur semblable dans unity
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetAxis("Mouse X")!= 0)
        {
            player.transform.Rotate(0, Input.GetAxis("Mouse X") * 50, 0);
        }
        if(Input.GetAxis("Mouse Y")!= 0)
        {
            playerCamera.transform.Rotate(-Input.GetAxis("Mouse Y") * 2, 0, 0);
        }
	}
}
