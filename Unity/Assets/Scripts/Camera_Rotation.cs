using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Rotation : MonoBehaviour {
    public float RotationSpeed;
	
	// Update is called once per frame
	void Update () {
        //transform.Rotate(Vector3.up * Time.deltaTime * 10);
        //transform.rotation = Quaternion.AngleAxis(30, Vector3.up * Time.deltaTime * 10);
        transform.Rotate(0, Input.GetAxis("Horizontal") * RotationSpeed * Time.deltaTime, 0, Space.World);
    }
}
