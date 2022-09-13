using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Line : MonoBehaviour
{
    public Vector3[] positions = new Vector3[150];
    int i = 0;
    public LineCollission lc;
    public static Action restart;
    bool isCanDraw = true;
    
    [SerializeField] LineRenderer _lineRenderer;
    [SerializeField] Rigidbody2D rb;
    private void Update() {
        BlindDrawing();
        if(Input.GetKeyDown(KeyCode.Space)){
            restart();
        }
    }

    void BlindDrawing(){
        if(Input.GetMouseButton(0)){
            if(isCanDraw){
                if(i == 1){
                i = 0;
                _lineRenderer.positionCount = 0;
            }
            Vector2 posV2 = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3 posV3 = new Vector3(posV2.x, posV2.y, 0);
            if(_lineRenderer.positionCount<=1){
                _lineRenderer.positionCount++;
                _lineRenderer.SetPosition(_lineRenderer.positionCount-1,posV3);
            }else{
                float dist = Vector3.Distance(_lineRenderer.GetPosition(_lineRenderer.positionCount-1), posV3);
                if(dist>0.08f){
                    _lineRenderer.positionCount++;
                    _lineRenderer.SetPosition(_lineRenderer.positionCount-1,posV3);
                }
            }
            if(_lineRenderer.positionCount>=150){
                isCanDraw = false;
            }
            }
        }
        if(Input.GetMouseButtonUp(0)){
            i=1;
            lc.SetEdgeCollider();
            rb.isKinematic = false;
            isCanDraw = true;
        }
    }
    
}
