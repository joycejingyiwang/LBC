using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lighton : MonoBehaviour
{
    public GameObject obj1;
    public GameObject obj2;
    public GameObject anchor;
    public float d;
    private float angle;
    private Vector3 origin;
    private Vector3 direction;

    // Update is called once per frame
    void Update()
    {
        d = Vector3.Distance(obj1.transform.position, obj2.transform.position);
        origin = anchor.transform.position- obj2.transform.position ;
        direction = obj1.transform.position - obj2.transform.position;
        angle = Vector3.Angle(origin, direction);

        if (d < 20 && angle < 30)
        {
           if (Input.GetMouseButtonDown(0))
                {

                if (this.GetComponent<Light>().enabled) {
                    this.GetComponent<Light>().enabled = false;
                }
                else
                {
                    this.GetComponent<Light>().enabled = true;
                }
            }
        }
    }
}
