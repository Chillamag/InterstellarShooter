﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerController : MonoBehaviour {

    public float moveForce = 5, boostMultiplyer = 2;
    Rigidbody2D myBody;

    // Use this for initialization
    void Start() {
        myBody = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate() {

        Vector2 moveVec = new Vector2(CrossPlatformInputManager.GetAxis("Horizontal"), CrossPlatformInputManager.GetAxis("Vertical")) * moveForce;
        bool isShooting = CrossPlatformInputManager.GetButton("Fire");

        myBody.AddForce(moveVec * (isShooting ? boostMultiplyer : 1));
    }
}