using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class drag : MonoBehaviour
{
	public Vector3 dpos;
	private Vector3 mOffset;
public GameObject gg;


	private float mZCoord;



	void OnMouseDown()

	{

		mZCoord = Camera.main.WorldToScreenPoint(

			gameObject.transform.position).z;

		mOffset = gameObject.transform.position - GetMouseAsWorldPoint();
		
		GameObject.Find("Text1").GetComponent<Text>().text="Name: "+this.name;
		GameObject.Find("Text2").GetComponent<Text>().text="Chrom: "+this.GetComponent<variables>().Chromosome;

	}



	private Vector3 GetMouseAsWorldPoint()

	{


		Vector3 mousePoint = Input.mousePosition;


		mousePoint.z = mZCoord;




		return Camera.main.ScreenToWorldPoint(mousePoint);

	}



	void OnMouseDrag()

	{

		transform.position = GetMouseAsWorldPoint() + mOffset;

	}

	void Start()
	{/*
		//Debug.Log(GameObject.Find(this.GetComponent<variables>().Chromosome).transform.position);
		if(this.GetComponent<variables>().Chromosome!="")
		if(this.GetComponent<variables>().Chromosome!="X")
			dpos=transform.position - GameObject.Find(""+(9000+int.Parse(this.GetComponent<variables>().Chromosome))).transform.position;
		else 
		dpos=transform.position - GameObject.Find("9000X").transform.position;
	*/}

}