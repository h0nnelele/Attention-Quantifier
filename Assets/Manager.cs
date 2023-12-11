using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;
    public GameObject canva1;
    public GameObject canva2;
    public GameObject canva3;
    public GameObject canva4;
    public GameObject canva5;
    public Listener listener;
    public GameObject player;
    public GameObject cube;
    public GameObject sphere;
    public GameObject cilindre;
    private bool once = true;

    public void Start()
    {
        source = canva1.GetComponent<AudioSource>();
        source.PlayDelayed(2.00F);


    }
    public void DisplayCanva2()
    {
        canva1.gameObject.SetActive(false);
        canva2.gameObject.SetActive(true);
        player.GetComponent<ActionBasedContinuousMoveProvider>().enabled = true;
        source = canva2.GetComponent<AudioSource>();
        source.PlayDelayed(1.00F);
    }

    public void HideCanva2()
    {
        canva2.gameObject.SetActive(false);
    }
    public void DisplayCanva3()
    {
        canva3.gameObject.SetActive(true);
        player.GetComponent<ActionBasedSnapTurnProvider>().enabled = true;
        source = canva3.GetComponent<AudioSource>();
        source.PlayDelayed(1.00F);
        //listener.JoystickListener();
    }
    public void HideCanva3()
    {
        canva3.gameObject.SetActive(false);
    }
    public void DisplayGrabable()
    {
        cube.gameObject.SetActive(true);
        cilindre.gameObject.SetActive(true);
        sphere.gameObject.SetActive(true);
        canva4.gameObject.SetActive(true);
        source = canva4.GetComponent<AudioSource>();
        source.PlayDelayed(1.00F);
    }
    public void DisplayCanva5()
    {
        if(once)
        {
            once = false;
            canva4.gameObject.SetActive(false);
            canva5.gameObject.SetActive(true);
            source = canva5.GetComponent<AudioSource>();
            source.PlayDelayed(3.00F);
        }
        

    }
    public void LoadSceneGallery()
    {
        if(GlobalTimeData.language == "spanish")
            SceneManager.LoadScene("Assets/Scenes/All scenes/no hint spanish/art_gallery_spanish.unity");
        else if(GlobalTimeData.language == "french")
            SceneManager.LoadScene("Assets/Scenes/All scenes/no hint french/art_gallery_french.unity");


    }

}
