using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestryObjects : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter(Collision collision){
      foreach (ContactPoint contact in collision.contacts){
        Destroy(this.gameObject);
      }
    }
}
