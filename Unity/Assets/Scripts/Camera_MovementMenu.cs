using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_MovementMenu : MonoBehaviour {
    public Camera cam;
    private Vector3 lookpoint;
    public float smoothSpeed;
    public Vector3 offset;



    // Update is called once per frame
    void Update()
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit rayhit;

        if (Physics.Raycast(ray, out rayhit))
        {
            lookpoint = new Vector3(rayhit.point.x, transform.position.y, rayhit.point.z);
            Vector3 DesiredPos = lookpoint + offset;
            Vector3 SmoothedPos = Vector3.Lerp(transform.position, DesiredPos, smoothSpeed * Time.deltaTime);
            transform.position = SmoothedPos;
        }
    }
}
