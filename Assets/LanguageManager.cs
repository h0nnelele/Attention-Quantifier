using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.SceneManagement;
using TMPro;

public class LanguageManager : MonoBehaviour
{
    public GameObject timeInput;
    public void LoadSpanishTuto()
    {
        GlobalTimeData.globalTime = timeInput.GetComponent<TMP_Text>().text;
        GlobalTimeData.language = "spanish";
        SceneManager.LoadScene("Assets/Scenes/All scenes/no hint spanish/tutorial_scene_spanish.unity");
        

    }
    public void LoadFrenchTuto()
    {

        GlobalTimeData.globalTime = timeInput.GetComponent<TMP_Text>().text; 
        GlobalTimeData.language = "french";
        SceneManager.LoadScene("Assets/Scenes/All scenes/no hint french/tutorial_scene_french.unity");
        

    }
}
