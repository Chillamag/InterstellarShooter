using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParaStarScroll : MonoBehaviour {

    public float parralax = 2f;
    public float offsetX = 1f;
    public float offsetY = 1f;

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update() {
        MeshRenderer mr = GetComponent<MeshRenderer>();

        Material mat = mr.material;
        Vector2 offset = mat.mainTextureOffset;
        offset.y += (Time.deltaTime / offsetY / parralax);
        //offset.y = transform.position.y / transform.localScale.y;
        offset.x = (transform.position.x / offsetX / parralax) ;
        mat.mainTextureOffset = offset;


    }
}
