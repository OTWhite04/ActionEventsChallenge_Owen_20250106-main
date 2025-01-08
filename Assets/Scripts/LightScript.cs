using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangeWallScript : MonoBehaviour
{
    public GameObject Light;

    // Start is called before the first frame update
    void Start()
    {
        //Actions.Spotlight += EnableLight;
    }


    // Update is called once per frame
    void Update()
    {
        //Getting the input for the P key.
        if (Input.GetKeyDown(KeyCode.P))
        {
            //Sends out a signal that other scripts pick up.
            Actions.Spotlight?.Invoke();
        }
    }

    
}
