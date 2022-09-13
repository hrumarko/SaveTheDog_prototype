using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineCollission : MonoBehaviour
{
    LineRenderer myLine;
    EdgeCollider2D edgeCol;

    
    private void Start() {
        edgeCol = GetComponent<EdgeCollider2D>();
    }
    private void Update() {
        
        
    }

    public void SetEdgeCollider(){
        myLine = GetComponent<LineRenderer>();
        List<Vector2> edges = new List<Vector2>();

        for(int point = 0; point < myLine.positionCount; point++){
            Vector3 lineRenderePoint = myLine.GetPosition(point);
            edges.Add(new Vector2(lineRenderePoint.x, lineRenderePoint.y));
            if(point %3 == 0|| point == 0 || point == myLine.positionCount-1){
                SetColliders(new Vector2(lineRenderePoint.x, lineRenderePoint.y));
            }
            
            

        }
        edgeCol.SetPoints(edges);

    }
    
    void SetColliders(Vector2 posV3){
        CircleCollider2D circleCollider = this.gameObject.AddComponent <CircleCollider2D>();
		circleCollider.offset = posV3;
		circleCollider.radius = 0.04f;
    }
}
