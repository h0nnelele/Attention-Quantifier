using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class LevelStarter : MonoBehaviour
{
    public GameObject player;
    public GameObject menu;
    // Start is called before the first frame update
    public void StartLevel()
    {
        SceneTimer.enabledTimer = true;
        this.gameObject.SetActive(false);
        if(player.GetComponent<ActionBasedContinuousMoveProvider>() != null)
        {
            player.GetComponent<ActionBasedContinuousMoveProvider>().enabled = true;
        }
        
    }
    public void DisplayMenu()
    {

        menu.gameObject.SetActive(true);
    }
}
