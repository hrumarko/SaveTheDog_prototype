using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarsOfLevels : MonoBehaviour
{
    public static int[] Stars= new int[4];
    void Awake()
    {
        for(int i = 1; i< 4; i++){
            Stars[i] = PlayerPrefs.GetInt(i + "stars");
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
