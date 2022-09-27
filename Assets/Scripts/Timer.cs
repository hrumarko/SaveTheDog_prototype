using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public GameObject winCanvas;
    int countCalls;
    int timerNum = 7;
    public int countStars;
    private void OnEnable() {
        Line.start += StartTime;
        countCalls = 0;
    }

    private void OnDisable() {
        Line.start -= StartTime;
    }
    void StartTime()
    {
        StartCoroutine(StartTimer());
    }

    // Update is called once per frame
    void Update()
    {
        timerText.text = timerNum.ToString();
        if(timerNum == 0){
            Debug.Log("1");
            GameManager.isGameOver = true;
            WinLevel();
            timerNum =-1;
        }
    }

    IEnumerator StartTimer(){
        while(timerNum >0){
            timerNum--;
            yield return new WaitForSeconds(1f);
        }
    }

    void WinLevel(){
        winCanvas.SetActive(true);
        CountTheStars();
        for(int i = 0; i <6; i++){
            var bee = FindObjectOfType<Bee>();
            Destroy(bee);
        }
    }

    public void StopTimer(){
        if(countCalls == 0){
            StopAllCoroutines();
            countCalls =1;
        }
        
        
    }

    void CountTheStars(){
        int a = FindObjectOfType<LineRenderer>().positionCount;
        if(a>0 && a<=70){
            countStars = 3;

        }

        if(a>70 && a<=140){
            countStars =2;
        }

        if(a>140 && a<=210){
            countStars =1;
        }

        PlayerPrefs.SetInt(SceneManager.GetActiveScene().buildIndex + "stars", countStars);
    }
}
