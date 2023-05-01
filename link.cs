using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class link : MonoBehaviour
{
	public GameObject lfab;
	public GameObject linkk=null;
	public GameObject linkk2=null;
	public GameObject target;
	public GameObject parent;
	public List<GameObject> g;
	//Vector3 dpos;
	//private LineRenderer linerend;
    // Start is called before the first frame update
List <Vector3> cc;
	IEnumerator waiter()
{
    yield return new WaitForSeconds(10);
}
    void Start()
    {
		
		StartCoroutine(waiter());
	//	linerend=GetComponent<LineRenderer>();
	//	linerend.sharedMaterial.SetColor("_Color",Color.gray);
	//	linerend.positionCount=5;
	//	dpos=GetComponent<drag>().dpos;
		//if(this.GetComponent<variables>().Chromosome!="")
		//if(this.GetComponent<variables>().Chromosome!="X")
			//parent=GameObject.Find(""+(9000+int.Parse(this.GetComponent<variables>().Chromosome)));
		//else
		//	parent=GameObject.Find("9000X");
		int i=0;
		cc=GameObject.Find("chromo").GetComponent<readJson>().color;
		if(this.GetComponent<variables>().target.Count>0)
			foreach(string x in this.GetComponent<variables>().target)
			{
				
				linkk=null;
				linkk=Instantiate(lfab,this.transform.position,Quaternion.identity);
				if(this.gameObject.GetComponent<variables>().Chromosome!="X")
				linkk.GetComponent<MeshRenderer>().material.color=new Color(cc[int.Parse(this.gameObject.GetComponent<variables>().Chromosome)].x,cc[int.Parse(this.gameObject.GetComponent<variables>().Chromosome)].y,cc[int.Parse(this.gameObject.GetComponent<variables>().Chromosome)].z);//new Color(Random.Range(0f,1f),Random.Range(0f,1f),Random.Range(0f,1f));
				//else
				//linkk.GetComponent<Renderer>().material.color=GameObject.Find("chromo").GetComponent<readJson>().color[24];//new Color(Random.Range(0f,1f),Random.Range(0f,1f),Random.Range(0f,1f));
				
				linkk.name=this.name+"///"+i;
				g.Add(linkk);
				i++;
				UpdateCylinderPosition(linkk,this.transform.position,GameObject.Find("G"+x).transform.position);
			}
		//linkk2=Instantiate(lfab,this.transform.position,Quaternion.identity);
        
    }

    
	private void UpdateCylinderPosition(GameObject cylinder, Vector3 beginPoint, Vector3 endPoint)
    {
        Vector3 offset = endPoint - beginPoint;
        Vector3 position = beginPoint + (offset / 2.0f);

        cylinder.transform.position = position;
        cylinder.transform.LookAt(beginPoint);
        Vector3 localScale = cylinder.transform.localScale;
        localScale.z = (endPoint - beginPoint).magnitude;
        cylinder.transform.localScale = localScale;
    }
	private void Update() {
	int i=0;
		foreach(GameObject b in g)
		{
			UpdateCylinderPosition(b,this.transform.position,GameObject.Find( "G"+this.GetComponent<variables>().target[i++]).transform.position);
		}	
	}
}
