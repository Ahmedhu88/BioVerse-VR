using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class presentation : MonoBehaviour
{

    public Sprite sp;
    public int index=1, count=2;
    


    public void nxt()
    {
        GameObject.Find("tvimage").gameObject.GetComponent<UnityEngine.UI.Image>().sprite=Resources.Load<Sprite>("Images/"+index);
        index=(index+1)%count;
    }

    public void back()
    {
        index=(index-1);
        if(index<0)
        index=count;
        GameObject.Find("tvimage").gameObject.GetComponent<UnityEngine.UI.Image>().sprite=Resources.Load<Sprite>("Images/"+index);
        
    }
   
}
