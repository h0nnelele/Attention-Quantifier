using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debuger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"name =: {GalleryData.name}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
