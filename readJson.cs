using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class readJson : MonoBehaviour
{
	
	
    public GameObject chro;
   public GameObject xx;
    public TextAsset textjson;
    [System.Serializable]
    public class node
    {
        public string id;
        public string Label;
        public string chromosome;
        public string url;
    }

    [System.Serializable]

    public class nodelist
    {
        public node[] nodes; 
    }

    [System.Serializable]
    public class link
    {
        public string source;
        public string target;
    }

    [System.Serializable]

    public class linklist
    {
        public link[] links;
    }

    public nodelist mynode = new nodelist();
    public linklist mylink = new linklist();
    public List<Vector3> loc;
    public List<Vector3> color;
    public List<string> objects;

    // Start is called before the first frame update
    void Start()
	{
        for(int ii=0;ii<=24;ii++)
        {
            color.Add(new Vector3(Random.Range(0,255),Random.Range(0,255),Random.Range(0,255)));
        }

        //linerend=GetComponent<LineRenderer>();
		//linerend.positionCount=2;
        //linerend.sharedMaterial.SetColor("_Color",Color.red);
        mynode = JsonUtility.FromJson<nodelist>(textjson.text);
        mylink = JsonUtility.FromJson<linklist>(textjson.text);

/*loc.Add(new Vector3(Random.Range(0,10),Random.Range(-20,20),Random.Range(-50,50)));
loc.Add(new Vector3(Random.Range(-100,100),Random.Range(-110,110),Random.Range(-150,150)));
loc.Add(new Vector3(Random.Range(0,10),Random.Range(-10,10),Random.Range(-50,50)));
loc.Add(new Vector3(Random.Range(0,10),Random.Range(-10,10),Random.Range(-50,50)));
loc.Add(new Vector3(Random.Range(0,10),Random.Range(-10,10),Random.Range(-50,50)));
loc.Add(new Vector3(Random.Range(0,10),Random.Range(-10,10),Random.Range(-50,50)));
loc.Add(new Vector3(Random.Range(0,10),Random.Range(-10,10),Random.Range(-50,50)));
loc.Add(new Vector3(Random.Range(0,10),Random.Range(-10,10),Random.Range(-50,50)));
loc.Add(new Vector3(Random.Range(0,10),Random.Range(-10,10),Random.Range(-50,50)));
loc.Add(new Vector3(Random.Range(0,10),Random.Range(-10,10),Random.Range(-50,50)));
loc.Add(new Vector3(Random.Range(0,10),Random.Range(-10,10),Random.Range(-50,50)));
loc.Add(new Vector3(Random.Range(0,10),Random.Range(-10,10),Random.Range(-50,50)));
loc.Add(new Vector3(Random.Range(0,10),Random.Range(-10,10),Random.Range(-50,50)));
loc.Add(new Vector3(Random.Range(0,10),Random.Range(-10,10),Random.Range(-50,50)));
loc.Add(new Vector3(Random.Range(0,10),Random.Range(-10,10),Random.Range(-50,50)));
loc.Add(new Vector3(Random.Range(0,10),Random.Range(-10,10),Random.Range(-50,50)));
loc.Add(new Vector3(Random.Range(0,10),Random.Range(-10,10),Random.Range(-50,50)));
loc.Add(new Vector3(Random.Range(0,10),Random.Range(-10,10),Random.Range(-50,50)));
loc.Add(new Vector3(Random.Range(0,10),Random.Range(-10,10),Random.Range(-50,50)));
loc.Add(new Vector3(Random.Range(0,10),Random.Range(-10,10),Random.Range(-50,50)));
loc.Add(new Vector3(Random.Range(0,10),Random.Range(-10,10),Random.Range(-50,50)));
loc.Add(new Vector3(Random.Range(0,10),Random.Range(-10,10),Random.Range(-50,50)));
loc.Add(new Vector3(Random.Range(0,10),Random.Range(-10,10),Random.Range(-50,50)));
*/

/*
loc.Add(new Vector3(10,0,45));
loc.Add(new Vector3(100,50,-45));
loc.Add(new Vector3(200,100,145));
loc.Add(new Vector3(300,-50,245));
loc.Add(new Vector3(400,-100,345));
loc.Add(new Vector3(500,150,445));
loc.Add(new Vector3(600,-150,545));
loc.Add(new Vector3(700,200,645));
loc.Add(new Vector3(800,-200,745));
loc.Add(new Vector3(900,250,845));
loc.Add(new Vector3(-150,-250,945));
loc.Add(new Vector3(-250,-300,-145));
loc.Add(new Vector3(-350,350,-245));
loc.Add(new Vector3(-450,400,-345));
loc.Add(new Vector3(-550,-450,-445));
loc.Add(new Vector3(-650,500,-545));
loc.Add(new Vector3(-750,-500,-645));
loc.Add(new Vector3(-850,600,-745));
loc.Add(new Vector3(-950,-600,-945));
loc.Add(new Vector3(1000,650,1045));
loc.Add(new Vector3(-1050,-650,1145));
loc.Add(new Vector3(1100,700,1245));
loc.Add(new Vector3(-1150,-700,1345));
loc.Add(new Vector3(1200,750,1445));


*/

		 for(int i=0;i<=24;i++)
		{
			loc.Add(new Vector3(Random.Range(-100,+150),Random.Range(-155,+155),i*10));
		}

        /*
		c = Instantiate(chro,new Vector3(0,0,230),Quaternion.identity);
					c.name="9000X";

		//linerend.SetPosition(0,new Vector3(0,0,0));
		//linerend.SetPosition(1,c.transform.localPosition);
        for(int i=0;i<mynode.nodes.Length;i++)
            {
                if(mynode.nodes[i].chromosome!="X")
                GameObject.Find(""+(9000+int.Parse(mynode.nodes[i].chromosome))).transform.localScale+=new Vector3(1,1,1);
                else
                GameObject.Find("9000X").transform.localScale+=new Vector3(1,1,1);
            }
*/



		//GameObject parent=null;
        for(int i=0;i<mynode.nodes.Length;i++)
        {
           // if(mynode.nodes[i].chromosome!="X")
			//parent=GameObject.Find(""+(9000+int.Parse(mynode.nodes[i].chromosome)));
            //else parent=GameObject.Find("9000X");
            if(mynode.nodes[i].chromosome!="X")
            {
                GameObject A = Instantiate(chro, new Vector3(Random.Range(loc[int.Parse(mynode.nodes[i].chromosome)].x-10,loc[int.Parse(mynode.nodes[i].chromosome)].x+10),
                                                         Random.Range(loc[int.Parse(mynode.nodes[i].chromosome)].y-10,loc[int.Parse(mynode.nodes[i].chromosome)].y+10),
                                                         Random.Range(loc[int.Parse(mynode.nodes[i].chromosome)].z-10,loc[int.Parse(mynode.nodes[i].chromosome)].z+10)),
                                                          Quaternion.identity) as GameObject;
			//A.transform.SetParent(GameObject.Find("parent").transform,true);
			A.name ="G"+int.Parse(mynode.nodes[i].id);
            A.GetComponent<variables>().Id=mynode.nodes[i].id;
            A.GetComponent<variables>().Label=mynode.nodes[i].Label;
            A.GetComponent<variables>().Chromosome=mynode.nodes[i].chromosome;
            A.GetComponent<variables>().url=mynode.nodes[i].url;
            A.GetComponent<Renderer>().material.color=new Color(color[int.Parse(mynode.nodes[i].chromosome)].x,color[int.Parse(mynode.nodes[i].chromosome)].y,color[int.Parse(mynode.nodes[i].chromosome)].z);
            objects.Add(A.name);
            }
            else
            {
                GameObject A = Instantiate(chro, new Vector3(Random.Range(loc[23].x-80,loc[23].x+10),
                                                            Random.Range(loc[23].y-50,loc[23].y+30),
                                                            Random.Range(loc[23].z-30,loc[23].z+20)),
                                                            Quaternion.identity) as GameObject;
			//A.transform.SetParent(GameObject.Find("parent").transform,true);
			A.name ="G"+int.Parse(mynode.nodes[i].id);
            A.GetComponent<variables>().Id=mynode.nodes[i].id;
            A.GetComponent<variables>().Label=mynode.nodes[i].Label;
            A.GetComponent<variables>().Chromosome=mynode.nodes[i].chromosome;
            A.GetComponent<variables>().url=mynode.nodes[i].url;
            A.GetComponent<Renderer>().material.color=new Color(color[24].x,color[24].y,color[24].z);;
            objects.Add(A.name);
            }
            
        }
        
        
        Debug.Log(mylink.links.Length);
        for(int i=0;i<mylink.links.Length;i++)
        {
            xx=null;
            //Debug.Log(i);
            xx= GameObject.Find("G"+int.Parse(mylink.links[i].source)) as GameObject;
            //Debug.Log(cc);
            Debug.Log(mylink.links[i].source);
            if (xx!=null)
            {//Debug.Log(xx.name);
            xx.GetComponent<variables>().target.Add(mylink.links[i].target);
            }else
            Debug.Log(mylink.links[i].source+" is null");
           //Debug.Log((mylink.links[i].target.ToString()));
        }
        /*    GameObject AA = Instantiate(empty,GameObject.Find(mylink.links[i].source).transform.position,Quaternion.identity);
            AA.name=mylink.links[i].source+"_child";
            AA.transform.parent=GameObject.Find(mylink.links[i].source).transform;

           GameObject BB = Instantiate(empty,GameObject.Find(mylink.links[i].target).transform.position,Quaternion.identity);
           BB.name=mylink.links[i].target+"_child";
           BB.transform.parent=GameObject.Find(mylink.links[i].target).transform;
            
           
            //linerend.SetPosition(0,GameObject.Find("PEX19").transform.position);
		    //linerend.SetPosition(1,GameObject.Find("ACSL3").transform.position);
/*            Debug.Log(mylink.links[i].source.ToString());
            linerend.SetPosition(0,GameObject.Find(mylink.links[i].source.ToString()).gameObject.transform.position);
		    linerend.SetPosition(1,GameObject.Find(mylink.links[i].target.ToString()).gameObject.transform.position);

        }

        		for(int i=1;i<23;i++)
                {
                    GameObject.Find(""+(9000+i)).GetComponent<Renderer>().material.SetColor("_Color",new Color(Random.Range(0f,1f),Random.Range(0f,1f),Random.Range(0f,1f)));          //new Color((float)i/23,(float)i/23,(float)i/23));
                }
*/



    }

    // Update is called once per frame
    void Update()
    {
		//linerend.SetPosition(0,new Vector3(0,0,0));
		//linerend.SetPosition(1,c.transform.localPosition);
    }
}
