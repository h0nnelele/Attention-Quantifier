using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zone2TriggerEnter : MonoBehaviour
{
    public Manager manager;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider c)
    {
        manager.DisplayCanva3();
    }
}
