using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InkReserve : MonoBehaviour
{
    public Slider slider;
    LineRenderer lineRenderer;
    void Start()
    {
        lineRenderer = FindObjectOfType<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(lineRenderer!=null)
        slider.value = lineRenderer.positionCount;
    }
}
