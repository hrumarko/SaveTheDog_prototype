using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static bool isGameOver = false;
    public Cat cat;
    void Start()
    {
        cat.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(isGameOver){
            
           StopGame();
           isGameOver = false;
        }
    }
    public void StopGame(){
        
        Destroy(FindObjectOfType<Cat>());
        
        
        
        
        
        
    }
}
