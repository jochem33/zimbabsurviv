using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Movement : MonoBehaviour {

    public GameObject player;
    public float smoothSpeed;
    public Vector3 offset;

    void Update () {
        Vector3 DesiredPos = player.transform.position + offset;
        Vector3 SmoothedPos = Vector3.Lerp(transform.position, DesiredPos, smoothSpeed * Time.deltaTime);
        transform.position = SmoothedPos;
    }
}
