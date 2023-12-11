using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showkeyboard : MonoBehaviour
{
    public void OpenKeyboard()
    {
        TouchScreenKeyboard.Open("", TouchScreenKeyboardType.PhonePad);
        Debug.Log("keyboardON");
    }
}
