using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

//Script: Rake the alpein

public class Player_Main : MonoBehaviour {

    public GameObject Menu_graszand;
    public GameObject pointer;
    public Camera cam;
    public NavMeshAgent agent;
    private Vector3 lookpoint;

    void Start()
    {
        cam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>() as Camera;
    }
    
    void Update () {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit rayhit;

        if (Physics.Raycast(ray, out rayhit))
        {
            lookpoint = new Vector3(rayhit.point.x, transform.position.y, rayhit.point.z);
            transform.LookAt(lookpoint);
            if (rayhit.transform.tag == "Tile")
            {
                if (Input.GetMouseButtonDown(0))
                {
                    //primary: move naar hitpoint en instantiate selectie particle 
                    agent.SetDestination(rayhit.transform.position);
                    //GameObject point = Instantiate(pointer, rayhit.transform.position, Quaternion.Euler(-90, 0, 0));
                    //Destroy(point, 2f);
                }
                if (Input.GetMouseButtonDown(1))
                {
                    if (rayhit.transform.name == "Tile_gras-zand")
                    {
                        Menu_graszand.SetActive(!Menu_graszand.activeInHierarchy);
                    }
                }
            }
        }
	}
}
