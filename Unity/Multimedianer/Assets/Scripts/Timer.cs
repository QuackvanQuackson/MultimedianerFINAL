using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
	float currentTime = 0f;
    float startingTime = 30f;
    
    public Text TimeDisplay;
	
    void Start ()
    {
		currentTime = startingTime;
	}

	void Update ()
    {
		currentTime -= 1 * Time.deltaTime; //jede sekunde
        TimeDisplay.text = currentTime.ToString ("0"); //nur ganze zahlen
        
        if(currentTime <= 0) //nicht negativ
        {
            currentTime = 0;
        }
	}
}
