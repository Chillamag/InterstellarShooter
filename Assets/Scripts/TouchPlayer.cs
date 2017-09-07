using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchPlayer : MonoBehaviour {

    public static bool guiTouch = false;

    public void TouchInput (Collider2D collider) {
        if(Input.touchCount > 0) {
            if(collider == Physics2D.OverlapPoint(Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position))) {
                switch (Input.GetTouch(0).phase) {
                    case TouchPhase.Began:
                        SendMessage("OnFirstTouchBegan", SendMessageOptions.DontRequireReceiver);
                        SendMessage("OnFirstTouch", SendMessageOptions.DontRequireReceiver);
                        guiTouch = true;
                        break;
                    case TouchPhase.Stationary:
                        SendMessage("OnFirstTouchStayed", SendMessageOptions.DontRequireReceiver);
                        SendMessage("OnFirstTouch", SendMessageOptions.DontRequireReceiver);
                        guiTouch = true;
                        break;
                    case TouchPhase.Moved:
                        SendMessage("OnFirstTouchMoved", SendMessageOptions.DontRequireReceiver);
                        SendMessage("OnFirstTouch", SendMessageOptions.DontRequireReceiver);
                        guiTouch = true;
                        break;
                    case TouchPhase.Ended:
                        SendMessage("OnFirstTouchEnded", SendMessageOptions.DontRequireReceiver);
                        SendMessage("OnFirstTouch", SendMessageOptions.DontRequireReceiver);
                        guiTouch = true;
                        break;
                }

            }
        }
        if (Input.touchCount > 1) {
                if (collider == Physics2D.OverlapPoint(Camera.main.ScreenToWorldPoint(Input.GetTouch(1).position))) {
                    switch (Input.GetTouch(1).phase) {
                        case TouchPhase.Began:
                            SendMessage("OnFirstTouchBegan", SendMessageOptions.DontRequireReceiver);
                            SendMessage("OnFirstTouch", SendMessageOptions.DontRequireReceiver);
                            guiTouch = true;
                            break;
                        case TouchPhase.Stationary:
                            SendMessage("OnFirstTouchStayed", SendMessageOptions.DontRequireReceiver);
                            SendMessage("OnFirstTouch", SendMessageOptions.DontRequireReceiver);
                            guiTouch = true;
                            break;
                        case TouchPhase.Moved:
                            SendMessage("OnFirstTouchMoved", SendMessageOptions.DontRequireReceiver);
                            SendMessage("OnFirstTouch", SendMessageOptions.DontRequireReceiver);
                            guiTouch = true;
                            break;
                        case TouchPhase.Ended:
                            SendMessage("OnFirstTouchEnded", SendMessageOptions.DontRequireReceiver);
                            SendMessage("OnFirstTouch", SendMessageOptions.DontRequireReceiver);
                            guiTouch = true;
                            break;
                    }
                }
        }
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
