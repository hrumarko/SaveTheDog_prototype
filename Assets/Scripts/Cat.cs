using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cat : MonoBehaviour
{
    Rigidbody2D _rb;
    public Timer timer;
    public GameObject loseCanvas;
    private void OnEnable() {
        Line.start += StartForce;
    }
    private void OnDisable() {
        Line.start -= StartForce;
    }
    void Start()
    {
        loseCanvas.SetActive(false);
    }
    void StartForce(){
        _rb = GetComponent<Rigidbody2D>();
        Vector3 forceVector = new Vector3(Random.Range(-1,1), 0, 0);
        _rb.AddForce(forceVector/4,ForceMode2D.Impulse);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "LoseZone"){
            Debug.Log("bb");
           GameOver();
        }
    }
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Bee"){
            GameOver();
        }
    }

    void GameOver(){
        timer.StopTimer();
        Invoke("LoadScene", 1f);
    }

    void LoadScene(){
        loseCanvas.SetActive(true);
        GameManager.isGameOver = true;
    }
}
