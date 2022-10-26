using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    float coffeeTemperature = 85.0f;
    float hotlimitTemmperature = 70.0f;
    float coldlimitTemperature = 40.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();
            
            coffeeTemperature -= Time.deltaTime * 5f;
    }

    void TemperatureTest ()
    {
        // If the coffe's temperature is greater than the hottest drinking temperature is greater thhan the hottest drinking temperature...
        if(coffeeTemperature > hotlimitTemmperature)
        {
            //... do this.
            print("Coffee is too hot");
        }
        //if it isnt, but the coffee temperature is less than the coldest drinking temperature...
        else if(coffeeTemperature < coldlimitTemperature)
        {
            // ... do this.
            print("Coffee is too cold.");
        }
        // If it is neither of those then...
        else
        {
            // ... do this.
            print("Coffee is just right.");
        }
    }
}
