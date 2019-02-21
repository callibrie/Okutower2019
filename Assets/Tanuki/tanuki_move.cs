using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tanuki_move : MonoBehaviour
{
    public float speed = 1.0f;
    public Transform target;
    public Vector3 position;

    public AudioClip racoonSound;
    private AudioSource source;

    private Vector3 curPos;
    private Vector3 lastPos;

    // Start is called before the first frame update
    void Awake()
    {
        position = gameObject.transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;    

        transform.position = Vector3.MoveTowards(transform.position, target.position, step);

        curPos = position;
        Debug.Log("Test");
        
        if(curPos != lastPos) {
            Debug.Log("Test2");
            if(!source.isPlaying){
                source.clip = racoonSound;
                source.Play();
            }
            
        }
        lastPos = curPos;
    }
}
