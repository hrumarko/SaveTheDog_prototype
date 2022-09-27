using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Uley : MonoBehaviour
{
    public GameObject bee;
    int count = 0;
    private void OnEnable() {
        Line.start += StartSpawnBees;
    }

    private void OnDisable() {
        Line.start -= StartSpawnBees;
    }
    public void StartSpawnBees() {
        StartCoroutine(SpawnBees());
    }
    IEnumerator SpawnBees(){
        while(count != 8){
            Instantiate(bee,this.transform.position, Quaternion.identity);
            count++;
            yield return new WaitForSeconds(0.15f);
        }
        
    }
}
