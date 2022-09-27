using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuButtons : MonoBehaviour
{
    public AudioSource audioSrc;
    public AudioClip clip;
    public GameObject levelsMenu;
    void PlaySound(){
        audioSrc.PlayOneShot(clip);
    }
    public void StartGame(){
        Time.timeScale = 1;
        SceneManager.LoadScene("Lvl1");
        PlaySound();
    }

    public void OpenLevel(int num){
        Time.timeScale = 1;
        SceneManager.LoadScene($"Lvl{num}");
        PlaySound();
    }
    public void OpenLevesMenu(){
        levelsMenu.SetActive(true);
        PlaySound();
    }

    public void CloseLevesMenu(){
        levelsMenu.SetActive(false);
        PlaySound();
    }

    public void DeleteAll(){
        PlayerPrefs.DeleteAll();
    }
}
