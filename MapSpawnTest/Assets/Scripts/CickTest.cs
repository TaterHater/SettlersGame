using UnityEngine;
using System.Collections;

public class CickTest : MonoBehaviour {

	public GameObject Town;
	public Transform MenuLoc;
	public GameObject buildMenu;
	public GameObject buildButton;
	public Texture BuildButtonText;
	public Vector3 TownCur = new Vector3(0,0,0);
	public bool click=false;



	void OnGUI() {
				if (click == true) {
						if (GUI.Button (new Rect (10, 10, 50, 50), BuildButtonText)) {
				Instantiate(Town,TownCur,Quaternion.Euler(0,Random.Range(0,90),0));
				click=false;
						}
				}
		}

	void OnMouseDown(){
		click = true;
		TownCur = (this.transform.position);
		print (TownCur);


	}
	void OnTriggerEnter(Collider other){
		if (other.tag == "interPoint") {
			Destroy(gameObject);
	}



		}




}
