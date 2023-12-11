using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyMaterialOne : MonoBehaviour
{
    public int id;
    public int count = 0;
    public Material newMaterial;
    public Material baseMaterial;
    // Start is called before the first frame update
    void Start()
    {
        GlobalEventManager.CameraHit += changeMaterial;
        GlobalEventManager.CameraOut += changeMaterial2;
        this.GetComponent<MeshRenderer>().material = baseMaterial;
    }

    // Update is called once per frame
    private void changeMaterial()
    {
        if ((GlobalEventManager.id == id) && (this.transform.GetComponent<MeshRenderer>().sharedMaterial.name != newMaterial.name))
        {
            this.transform.GetComponent<MeshRenderer>().material = newMaterial;
            count++;
            GlobalEventManager.sequence.Add(id);
        }
        
    }
    private void changeMaterial2()
    {
        if (this.transform.GetComponent<MeshRenderer>().sharedMaterial.name != baseMaterial.name)
        this.GetComponent<MeshRenderer>().material = baseMaterial;
    }
}
