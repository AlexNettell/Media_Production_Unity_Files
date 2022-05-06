using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class talkToUI : MonoBehaviour
{
    public Text propToUI;
    public string message;

    void OnMouseDown()
    {
    	propToUI.text = message;
    }
}
