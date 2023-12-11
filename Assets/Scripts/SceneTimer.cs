using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class SceneTimer : MonoBehaviour
{
    public float currentTime = 0;
    public float stopValue;
    public static bool enabledTimer = false;
    public Camera mainCam;
    public GameObject player;
    public GameObject leftInteractor;
    public GameObject rightInteractor;
    public Canvas canva;
    public Canvas canva2;
    public float rx;
    public float ry;
    public float rz;
    public float px;
    public float py;
    public float pz;
    // Start is called before the first frame update
    void Start()
    {
        stopValue = float.Parse(GlobalTimeData.globalTime);
        enabledTimer = false;
        canva.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (currentTime <= stopValue  && enabledTimer == true)
            currentTime = currentTime + Time.deltaTime;
        else 
        {
            if (currentTime >= stopValue ) 
                StartCoroutine("disableCMP");
        }

    }
    IEnumerator disableCMP()
    {

        if (player.GetComponent<ActionBasedContinuousMoveProvider>() != null)
        {
            player.GetComponent<ActionBasedContinuousMoveProvider>().enabled = false;
        }
        yield return new WaitForSeconds(0.1F);
        player.transform.position = (new Vector3(px, py, pz));
        player.transform.rotation = Quaternion.Euler(rx, ry, rz);
       // leftInteractor.gameObject.GetComponent<XRRayInteractor>().SetActive(true);
        canva.gameObject.SetActive(true);
        yield return new WaitForSeconds(0.1F);
        enabledTimer = false;
    }

    public void EnableTimer()
    {
        enabledTimer = true;
    }
}
