using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunRise : MonoBehaviour
{
    public float speed = 12f;



    // Update is called once per frame
    void Update()
    {
        Vector3 rotation = new Vector3(-speed, 0, 0);
        
        gameObject.transform.Rotate(rotation * Time.deltaTime);
    }
}
