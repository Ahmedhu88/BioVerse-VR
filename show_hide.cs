using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class show_hide : MonoBehaviour
{
    public GameObject dr;
    // Start is called before the first frame update
    bool sh;
    List<string> list1;
    void Start()
    {
        sh=false;
        list1=GameObject.Find("chromo").GetComponent<readJson>().objects;

    }

    // Update is called once per frame
   public void action()
    {
Debug.Log(dr.GetComponent<UnityEngine.UI.Dropdown>().options[dr.GetComponent<UnityEngine.UI.Dropdown>().value].text);
        
        sh=!sh;
        
        {
            foreach (string x in list1)
            if(GameObject.Find(x).GetComponent<variables>().Chromosome=="X")
            for(int i=0;i<GameObject.Find(x).GetComponent<variables>().target.Count;i++)
            {
                if(GameObject.Find( "G"+GameObject.Find(x).GetComponent<variables>().target[i]).GetComponent<variables>().Chromosome==dr.GetComponent<UnityEngine.UI.Dropdown>().options[dr.GetComponent<UnityEngine.UI.Dropdown>().value].text)
                    {
                        GameObject.Find(x+"///"+i).GetComponent<MeshRenderer>().enabled=sh;
                        Debug.Log(x+"///"+i+"   "+sh);
                    }
            }
        }
    }

        
    
}
