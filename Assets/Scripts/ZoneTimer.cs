using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneTimer : MonoBehaviour
{
    public float zoneTime = 0;
    public bool enabledTimer = false;
    public Collider playerCollider;
   

    // Update is called once per frame
    void Update()
    {
        if ((enabledTimer) && (SceneTimer.enabledTimer))
            zoneTime = zoneTime + Time.deltaTime;
    }
    void OnTriggerEnter(Collider other)
    {
        
        enabledTimer = true;
        Debug.Log("hohoho!");
    }
    void OnTriggerExit(Collider other)
    {
        enabledTimer = false;
        Debug.Log("HEYHEYHEY");
    }
}
