using UnityEngine;
using System.Collections;

public class townDetection : MonoBehaviour {

	public GameObject Test1;
	public int isNextToWheat = 0;
	public int isNextToBrick = 0;
	public int isNextToSheep = 0;
	public int isNextToOre = 0;
	public int isNextToWood = 0;
	public int isNextToDesert = 0;
	//public int isNextToWater = 0;


	// Use this for initialization
	void Start () {


	}
	void OnTriggerEnter(Collider other){
			   if (other.tag == "brick") {
				isNextToBrick  += 1;
		} else if (other.tag == "desert") {
				isNextToDesert += 1;
		} else if (other.tag == "forest") {
				isNextToWood   += 1;
		} else if (other.tag == "wheat") {
				isNextToWheat  += 1;
		} else if (other.tag == "sheep") {
				isNextToSheep  += 1;
		} else if (other.tag == "ore") {
				isNextToOre    += 1;
		} else {
				//isNextToWater  += 1;
		}
		
		
		
		
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
