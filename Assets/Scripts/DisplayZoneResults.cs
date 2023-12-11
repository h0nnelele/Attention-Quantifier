using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DisplayZoneResults : MonoBehaviour
{
    public GameObject zoneA,zoneB, zoneC;
    public TextMeshProUGUI timerA,timerB,timerC;
    // Start is called before the first frame update
    void Start()
    {
        GlobalEventManager.TimerOut += displayZoneScore;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void displayZoneScore()
    {
        timerA.GetComponent<TextMeshProUGUI>().text = zoneA.transform.GetComponent<ZoneTimer>().zoneTime.ToString("F2");
        timerB.GetComponent<TextMeshProUGUI>().text = zoneB.transform.GetComponent<ZoneTimer>().zoneTime.ToString("F2");
        timerC.GetComponent<TextMeshProUGUI>().text = zoneC.transform.GetComponent<ZoneTimer>().zoneTime.ToString("F2");
        //time.GetComponent<TextMeshProUGUI>().text = painting.transform.GetComponent<Timer>().currentTime.ToString("F2");
    }
}
