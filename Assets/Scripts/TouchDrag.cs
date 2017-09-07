using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchDrag : TouchPlayer {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        TouchInput(GetComponent<Collider2D>());
	}

    void OnFirstTouch() {
        Vector3 pos;

        pos = new Vector3(Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position).x, Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position).y, transform.position.z);
        transform.position = pos;
        
    }
}
