using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class upanddown : MonoBehaviour
{
   
    public void moveUp()
    {
        this.transform.position=new Vector3(this.transform.position.x,this.transform.position.y+10,this.transform.position.z);
        
    }
     void Update()
    {
        if (OVRInput.Get(OVRInput.Button.One)){
            Debug.Log("A button pressed");
            moveUp();
        }
        
    }
}
