using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlay : MonoBehaviour
{
    private AudioSource source;
    
    // Start is called before the first frame update
    public void Start()
    {
        source = this.gameObject.GetComponent<AudioSource>();
        source.PlayDelayed(2.00F);


    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
