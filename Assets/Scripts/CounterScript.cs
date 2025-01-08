using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CounterScript : MonoBehaviour
{
    private TextMeshProUGUI countText;
    int number = 0;

    private void Start()
    {
        countText = GetComponent<TextMeshProUGUI>();
    }

   public void Count()
    {
        number += 100;
        countText.text = "Count: " + number.ToString();
    }

    public void OnEnable()
    {
        Actions.Spotlight += Count;

    }

    public void OnDisable()
    {
        Actions.Spotlight -= Count;

    }


}
