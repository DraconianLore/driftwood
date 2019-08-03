using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orbitcam : MonoBehaviour {

    public Transform target;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // Rotate the camera every frame so it keeps looking at the target
        transform.LookAt(target);
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.RotateAround(target.transform.position, Vector3.down, Time.deltaTime * 25);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.RotateAround(target.transform.position, Vector3.up, Time.deltaTime * 25);
        }

    }
}
