using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap;
using Leap.Unity;

public class Destroy : MonoBehaviour
{
    public Transform explosionPrefab;
    // Start is called before the first frame update
    void Start()
    {

    }

    void OnCollisionEnter(Collision collision) {

      ContactPoint contact = collision.contacts[0];
       // Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
       Vector3 pos = contact.point;
       // Instantiate(explosionPrefab, pos, rot);
        Instantiate (explosionPrefab, pos, Quaternion.identity);
        Destroy(this.gameObject);
    HandModelBase hand = collision.gameObject.GetComponentInParent<HandModelBase>();
    if(hand != null){

       // Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
       
       // Instantiate(explosionPrefab, pos, rot);
        Instantiate (explosionPrefab, pos, Quaternion.identity);
        Destroy(this.gameObject);
    }

  }
}
