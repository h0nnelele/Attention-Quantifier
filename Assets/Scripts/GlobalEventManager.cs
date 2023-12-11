using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.XR.Interaction.Toolkit;

public class GlobalEventManager : MonoBehaviour
{
    public static event Action CameraHit;
    public static event Action TimerOut;
    public static event Action CameraOut;
    public Camera mainCam;
    public GameObject player;
    RaycastHit hit;
    Ray ray;
    public static List<int> sequence = new List<int>();
    public static int id;
    public Canvas canva;
    public Canvas canva2;
    //private ActionBasedContinuousMoveProvider cmp;
    public void Start()
    {
        canva.gameObject.SetActive(false);
        canva2.gameObject.SetActive(false);
    }
    public void Update()
    {
        ray = mainCam.ViewportPointToRay(new Vector3(0.5F, 0.5F, 0));
        if (SceneTimer.enabledTimer)
        {
            if ((Physics.Raycast(ray, out hit)) && (hit.transform.gameObject.tag == "painting"))
            {
                id = hit.transform.GetComponent<ApplyMaterialOne>().id;
                CameraHit?.Invoke();
            }
            else
                CameraOut?.Invoke();    
        }
        else
        {
            StartCoroutine("disableCMP");
            
        }
    }
    IEnumerator disableCMP()
    {
        player.GetComponent<ActionBasedContinuousMoveProvider>().enabled = false;
        yield return new WaitForSeconds(0.1F);
        canva.gameObject.SetActive(true);
        Console.WriteLine(string.Join(", ", GlobalEventManager.sequence));
    }
}

