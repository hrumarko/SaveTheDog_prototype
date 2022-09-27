using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Level : MonoBehaviour
{
    public int Num;
    public Image oneStar;
    public Image twoStar;
    public Image threeStar;
    
    void Start(){
        Debug.Log($"{StarsOfLevels.Stars[Num]} + {Num}");
        if(StarsOfLevels.Stars[Num]==0){
            oneStar.color = new Color(0.5f,0.5f,0.5f,255);
            twoStar.color = new Color(0.5f,0.5f,0.5f,255);
            threeStar.color = new Color(0.5f,0.5f,0.5f,255);
        }

        if(StarsOfLevels.Stars[Num]==1){
            oneStar.color = new Color(1f,1f,1f,255);
            twoStar.color = new Color(0.5f,0.5f,0.5f,255);
            threeStar.color = new Color(0.5f,0.5f,0.5f,255);
        }

        if(StarsOfLevels.Stars[Num]==2){
            oneStar.color = new Color(1f,1f,1f,255);
            twoStar.color = new Color(1f,1f,1f,255);
            threeStar.color = new Color(0.5f,0.5f,0.5f,255);
        }

        if(StarsOfLevels.Stars[Num]==3){
            oneStar.color = new Color(1f,1f,1f,255);
            twoStar.color = new Color(1f,1f,1f,255);
            threeStar.color = new Color(1f,1f,1f,255);
        }
        
    }
}
