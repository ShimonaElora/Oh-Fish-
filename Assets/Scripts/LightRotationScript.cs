using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightRotationScript : MonoBehaviour {

    float initYAngle;
    float initXAngle;
    public float ySpeed;
    public float xSpeed;

	// Use this for initialization
	void Start () {
        initXAngle = GetComponent<Transform>().rotation.x;
        initXAngle = GetComponent<Transform>().rotation.y;
	}
	
	// Update is called once per frame
	void Update () {
        initXAngle = initXAngle + 0.0001f * xSpeed;
        initYAngle = initYAngle + 0.0001f * ySpeed;
        transform.Rotate(0.1f * xSpeed, 0.1f * ySpeed, 0);
        //GetComponent<Transform>().rotation = new Quaternion(initXAngle, initYAngle, GetComponent<Transform>().rotation.z, GetComponent<Transform>().rotation.w);
	}
}
