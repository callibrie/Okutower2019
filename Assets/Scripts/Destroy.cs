using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap;
using Leap.Unity;

public class Destroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    void OnCollisionEnter(Collision collision) {
    HandModelBase hand = collision.gameObject.GetComponentInParent<HandModelBase>();
    if(hand != null){
        Destroy(this.gameObject);
    }
  }
}
