using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;
public class RandommizeBackground : MonoBehaviour
{
    
 
    Color colorStart;
    Color colorEnd;
    [SerializeField]
    float rate = 1;  // Number of times per second new colour is chosen
    float i = 0; // Counter to control lerp
    [SerializeField]
    private RawImage rend; 

    
    
 
    void Update()
    {
        // Blend towards the current target colour
        i += Time.deltaTime*rate;
        rend.color = Color.Lerp (colorStart, colorEnd, i);
 
        // If we've got to the current target colour, choose a new one
        if (i >= 1)
        {
            i = 0;
            colorStart = rend.color;
            colorEnd = new Color (Random.value, Random.value, Random.value);
        }
    }
}
