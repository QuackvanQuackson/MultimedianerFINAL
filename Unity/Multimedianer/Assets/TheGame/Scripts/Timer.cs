using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
	float currentTime = 0.0f;
    float startingTime = 30.0f;
    
    public Text TimeDisplay;
	
    void Start ()
    {
		currentTime = startingTime;
	}

	void Update ()
    {
		currentTime -= Time.deltaTime; //jede sekunde
        TimeDisplay.text = currentTime.ToString ("0"); //nur ganze zahlen
        
        if(currentTime <= 0) //nicht negativ
        {
            currentTime = 0;
        }
	}
}
