using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookat : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation=Quaternion.LookRotation(transform.position- GameObject.Find("XROrigin").gameObject.transform.position);
        //transform.LookAt(GameObject.Find("XROrigin").transform,Vector3.back);
    }
}
