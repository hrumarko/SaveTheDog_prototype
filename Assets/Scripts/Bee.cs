using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bee : MonoBehaviour
{
    
    Rigidbody2D _rb;
    public float force;
    void Start()
    {
        var cat = FindObjectOfType<Cat>();
        _rb = GetComponent<Rigidbody2D>();
        _rb.AddForce((cat.transform.position-this.transform.position), ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
         
    }
    private void OnCollisionEnter2D(Collision2D other) {
       StartCoroutine(BeeMoving());
    }
    private void OnCollisionStay2D(Collision2D other) {
       StartCoroutine(BeeMoving());
    }

    IEnumerator BeeMoving(){
        var cat = FindObjectOfType<Cat>();
        float x = Random.Range(-1, 1);
        float y = Random.Range(-1, 1);
        _rb.AddForce(new Vector2(x, y) * force, ForceMode2D.Impulse);
        yield return new WaitForSeconds(0.5f);
        if(this !=null && cat != null)
        _rb.AddForce((cat.transform.position-this.transform.position)/force, ForceMode2D.Impulse);
    }
}
