using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class telephone : MonoBehaviour
{
    public GameObject obj1;
    public GameObject obj2;
    public float d;

    void Update()
    {

        Renderer rend = this.GetComponent<Renderer>();
        d = Vector3.Distance(obj1.transform.position, obj2.transform.position);

        if (Input.GetMouseButtonDown(0) && d < 10)
        {
            if (rend.enabled)
            {
                rend.enabled = false;
            }
            else {
                rend.enabled = true;
            }

        }
    }
}
