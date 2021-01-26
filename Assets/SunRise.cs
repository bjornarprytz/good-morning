using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunRise : MonoBehaviour
{
    Vector3 rotation = new Vector3(-0.04f, 0, 0);


    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(rotation);
    }
}
