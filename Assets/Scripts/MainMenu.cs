using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public AudioClip menuSelectSound;
    
    private AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onPressBtn(string btn_name) 
    {
        source.PlayOneShot(menuSelectSound,0.5f);

        if (btn_name == "ranking") {
            SceneManager.LoadScene("Ranking", LoadSceneMode.Single);
        }
        else if (btn_name == "quit") {
            Debug.Log(btn_name);
        }
        else {
            SceneManager.LoadScene("Tutorial", LoadSceneMode.Single);
        }
        Debug.Log(btn_name);
    }
}
