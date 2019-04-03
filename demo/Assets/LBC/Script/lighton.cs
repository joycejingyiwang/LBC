using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lighton : MonoBehaviour
{
    public GameObject obj1;
    public GameObject obj2;
    public float d;

    // Update is called once per frame
    void Update()
    {
        d = Vector3.Distance(obj1.transform.position, obj2.transform.position);

        if (Input.GetKeyDown(KeyCode.O)&& d<20)
        {
            if( this.GetComponent<Light>().enabled) {
                this.GetComponent<Light>().enabled = false;
            }
            else
            {
                this.GetComponent<Light>().enabled = true;
            }
        }
      
    }
}
