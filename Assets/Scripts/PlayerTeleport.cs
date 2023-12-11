using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTeleport : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GlobalEventManager.TimerOut += teleportPlayer;
    }

    // Update is called once per frame
    void teleportPlayer()
    {
        gameObject.transform.position = (new Vector3(-1, 0, 0));
        this.transform.rotation = Quaternion.Euler(0, -90, 0);
        Debug.Log("IT HAPPENED");
        GlobalEventManager.TimerOut -= teleportPlayer;
    }
}
