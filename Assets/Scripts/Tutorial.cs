using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tutorial : MonoBehaviour
{
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
        if (btn_name == "skip") {
            SceneManager.LoadScene("Terrain", LoadSceneMode.Single);
        }
    }
}
