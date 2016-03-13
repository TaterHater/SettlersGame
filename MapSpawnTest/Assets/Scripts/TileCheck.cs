using UnityEngine;
using System.Collections;

public class TileCheck : MonoBehaviour {
	
	public Material Desert;
	public Material Forest;
	public Material Brick;
	public Material Sheep;
	public Material Ore;
	public Material Wheat;
	private float hill;
	//public GameObject TC;
	private float waitTime=1;
	void Start () {
		waitTime = Random.Range (0.1f,1);
		
	}
	IEnumerator Wait(){
		yield return new WaitForSeconds(waitTime);
	}
	void Update(){
		hill = Random.Range (0, 10);
	}
	
	
	void OnTriggerEnter(Collider other){
		switch (other.tag) {
		case "desert": 
			this.GetComponent<Renderer>().material = Desert;
			this.tag = "desert";
			break;
		case "forest":
			this.GetComponent<Renderer>().material = Forest;
			this.tag = "forest";
			break;
		case "brick":
			this.GetComponent<Renderer>().material = Brick;
			this.tag = "brick";
			break;
		case "sheep":
			this.GetComponent<Renderer>().material = Sheep;
			this.tag = "sheep";
			break;
		case "ore":
			this.GetComponent<Renderer>().material = Ore;
			this.tag = "ore";
			hill = Random.Range (0, 10);
			this.transform.position=new Vector3(this.transform.position.x,hill,this.transform.position.z);
			break;
		case "wheat":
			this.GetComponent<Renderer>().material = Wheat;
			this.tag = "wheat";
			break;
		default:
			break;

		
		}



	}
}
