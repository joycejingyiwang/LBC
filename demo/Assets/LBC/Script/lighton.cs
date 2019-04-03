using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lighton : MonoBehaviour
{
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.O))
        {
            this.GetComponent<Light>().enabled = true;
        }
        if (Input.GetKey(KeyCode.F))
        {
            this.GetComponent<Light>().enabled = false;
        }
    }
}
