using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    void Start()
    {}

    void Update()
    {}

    private void OnTriggerEnter(Collider other)
    {
    	if(other.tag == "myTagName"){
    		Debug.Log("Trigger activated!");

    	}
    }

    void OnTriggerExit(Collider other)
    {
    	
    }
}
