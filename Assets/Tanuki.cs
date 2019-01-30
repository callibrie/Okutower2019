using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tanuki : MonoBehaviour
{
    GameObject tower;
    GameObject terrain;
    float floatValue = 0.5f;

    public float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        tower = GameObject.Find("Tower");
        terrain = GameObject.Find("Terrain");
    }

    // Update is called once per frame
    void Update()
    {
        if (tower == null)
        {
            Destroy(this.gameObject);
        }
        else
        {
            Vector3 dir = tower.transform.position - this.transform.localPosition;
            float distanceTraveled = speed * Time.deltaTime;

            //move towards the tower
            this.transform.Translate(dir.normalized * distanceTraveled, Space.World);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Physics.IgnoreCollision(this.transform.GetComponent<Collider>(), GetComponent<Collider>());
        }
    }
}
