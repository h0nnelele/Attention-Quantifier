using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
public class Listener : MonoBehaviour
{
    private InputDevice targetDevice;
    public GameObject canva;
    private bool doneOnce = true;

    // Update is called once per frame
    public void JoystickListener()
    {
        List<InputDevice> devices = new List<InputDevice>();
        InputDeviceCharacteristics rightControllerCharacteristics = InputDeviceCharacteristics.Right | InputDeviceCharacteristics.Controller;
        InputDevices.GetDevicesWithCharacteristics(rightControllerCharacteristics, devices);
        if(devices.Count > 0)
        {
            targetDevice = devices[0];
        }
        StartCoroutine(JoystickCheck());

    }
    //void Start()
    //{
    //    List<InputDevice> devices = new List<InputDevice>();
    //    InputDeviceCharacteristics rightControllerCharacteristics = InputDeviceCharacteristics.Right;
    //    InputDevices.GetDevicesWithCharacteristics(rightControllerCharacteristics, devices);
    //    if (devices.Count > 0)
    //    {
    //        targetDevice = devices[0];
    //    }
    //    else
    //        Debug.Log("chloupiiii");
    //}
    //void Update()
    //{
    //    List<InputDevice> devices = new List<InputDevice>();
    //    InputDeviceCharacteristics rightControllerCharacteristics = InputDeviceCharacteristics.Right;
    //    InputDevices.GetDevicesWithCharacteristics(rightControllerCharacteristics, devices);
    //    if (devices.Count > 0)
    //    {
    //        targetDevice = devices[0];
    //    }
    //    else
    //        Debug.Log("chloupiiii");
    //    if (targetDevice.TryGetFeatureValue(CommonUsages.primary2DAxis, out Vector2 primary2DAxisValue) && primary2DAxisValue != Vector2.zero)
    //            Debug.Log("Primary Touchpad" + primary2DAxisValue);
        
    //}
    IEnumerator JoystickCheck()
    {
        
        while (doneOnce)
        {
            if (targetDevice.TryGetFeatureValue(CommonUsages.primary2DAxis, out Vector2 primary2DAxisValue) && primary2DAxisValue != Vector2.zero)
            {
                canva.gameObject.SetActive(false);
                doneOnce = false;
                yield return new WaitForSeconds(Random.Range(0, 0.5F));
            }

            //Debug.Log("Primary Touchpad" + primary2DAxisValue);
        }
    }
}
