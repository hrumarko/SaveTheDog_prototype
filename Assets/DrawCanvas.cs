using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawCanvas : MonoBehaviour
{
    public GameObject drawCanvas;
    GameObject thisCanvas;
    private void OnEnable() {
        Line.restart +=DeleteDrawCanvas;
        Line.restart +=CreateDrawCanvas;
    }
    private void OnDisable() {
        Line.restart -=DeleteDrawCanvas;
        Line.restart -=CreateDrawCanvas;
    }

    void Awake(){
        CreateDrawCanvas();
    }
    public void CreateDrawCanvas(){
        thisCanvas = Instantiate(drawCanvas);
    }

    public void DeleteDrawCanvas(){
        Destroy(thisCanvas);
    }

}
