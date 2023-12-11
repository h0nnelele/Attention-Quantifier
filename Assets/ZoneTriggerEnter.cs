using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneTriggerEnter : MonoBehaviour
{
    public Manager manager;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider c)
    {
        manager.HideCanva2();
    }
}
