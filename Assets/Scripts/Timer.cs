using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Timer : MonoBehaviour
{
    public float currentTime = 0;
    //public float finalTime = 0;
    public bool enabledTimer = false;
    // Start is called before the first frame update
    void Start()
    {
        GlobalEventManager.CameraHit += enableTimer;
        GlobalEventManager.CameraOut += disableTimer;
        GlobalEventManager.TimerOut += disableTimer;

    }

    // Update is called once per frame
    void Update()
    {
        if (enabledTimer)
            currentTime = currentTime + Time.deltaTime;
    }
    void enableTimer()
    {
        if ((GlobalEventManager.id == this.transform.GetComponent<ApplyMaterialOne>().id) && (!enabledTimer))
            enabledTimer = true;
    }
    void disableTimer()
    {
        //if ((GlobalEventManager.id == this.transform.GetComponent<ApplyMaterialOne>().id) && (enabledTimer))
            enabledTimer = false;
    }
}
