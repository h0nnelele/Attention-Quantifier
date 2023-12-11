using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Writer : MonoBehaviour
{

    //string word = null;
    //int wordIndex = 0;
    //string alpha;
    public TMP_InputField focus;
    // Use this for initialization

    public void alphabetFunction(string alphabet)
    {
        focus.text = focus.text + alphabet;

    }
    public void backspace()
    {
        if(focus.text.Length>0)
            focus.text = focus.text.Remove(focus.text.Length - 1);
    }
}