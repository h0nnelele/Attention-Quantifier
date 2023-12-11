using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DisplayResults : MonoBehaviour
{
    public GameObject frame;
    public TextMeshProUGUI count;
    public TextMeshProUGUI time;
    public TextMeshProUGUI score;
    // Start is called before the first frame update
    void Start()
    {
        //GlobalEventManager.TimerOut += displayScore;
    }

    // Update is called once per frame
    void Update()
    {
        if(SceneTimer.enabledTimer)
            displayScore();
    }
    public void displayScore()
    {
        count.GetComponent<TextMeshProUGUI>().text = frame.transform.GetChild(3).gameObject.GetComponent<Text>().text;
        time.GetComponent<TextMeshProUGUI>().text = frame.transform.GetChild(2).gameObject.GetComponent<Text>().text;
        score.GetComponent<TextMeshProUGUI>().text = frame.transform.GetChild(1).gameObject.GetComponent<Text>().text;
    }
}
