using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using TMPro;

public class Activate : MonoBehaviour
{
    public GameObject panel1;
    public GameObject panel2;
    public Canvas canva;
    public void activate()
    {
        canva.gameObject.SetActive(true);
        panel1.gameObject.SetActive(true);
        panel2.gameObject.SetActive(false);
        Debug.Log("HELLO");
    }


}
