using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camBehaviour : MonoBehaviour
{
    public GameObject cube;
    public Material material1;
    public Material material2;
    Renderer rend;
    Camera cam;
    RaycastHit hit;
    Ray ray;
    void Start()
    {
        cam = GetComponent<Camera>();
        //var rend = cube.GetComponent<MeshRenderer>();
        //rend.material.SetColor("_Color", Color.red);
    }

    void Update()
    {
        ray = cam.ViewportPointToRay(new Vector3(0.5F, 0.5F, 0));
        
        if (Physics.Raycast(ray, out hit))
        {
            if ((hit.transform.name == cube.transform.name) && (hit.transform.GetComponent<MeshRenderer>().material != material1))
            {
                print("I'm looking at a fucking cube bro");
                hit.transform.GetComponent<MeshRenderer>().material = material1;
                
            }
        }
        else
            if (cube.GetComponent<MeshRenderer>().material != material2)
                cube.GetComponent<MeshRenderer>().material = material2;
    }
}
