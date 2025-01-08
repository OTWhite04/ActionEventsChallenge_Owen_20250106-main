using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitchScript : MonoBehaviour
{
    //light object.
    public Light light;

    //Method for turning light on.
    public void TurnLightOn()
    {
        //Makes the light enable.
        light.enabled = true;
        Invoke("TurnLightOff", 0.5f);
    }
    //Method for turning light off.
    public void TurnLightOff()
    {
        light.enabled = false;
    }

   
    //Subscribes to action.
    public void OnEnable()
    {
        Actions.Spotlight += TurnLightOn;
        
    }
    //Unsubscribes to action.
    public void OnDisable()
    {
        Actions.Spotlight -= TurnLightOn;
        
    }



}
