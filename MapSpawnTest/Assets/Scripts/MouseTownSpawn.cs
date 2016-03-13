using UnityEngine;
using System.Collections;

public class MouseTownSpawn : MonoBehaviour {
	private Vector3 mouseLoc;

	public GameObject Town;

	public GameObject buildButton;
	public Texture BuildButtonText;
	private RaycastHit rayInfo;
	void Update () {

		/*
		if (Input.GetButtonDown ("Fire1")) {
		

			Ray ray=Camera.main.ScreenPointToRay(mouseLoc);
			RaycastHit hit;
			if(Physics.Raycast(ray,out hit,1000f)) {
				townLoc=hit.point;
			} else {
				townLoc=Camera.main.ScreenToWorldPoint(mouseLoc);
			}


				Instantiate(Town,townLoc, Quaternion.identity);


		}

*/

		//mouseLoc = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0f);
		//townLoc = Camera.current.ScreenToWorldPoint(mouseLoc);
		if (Input.GetMouseButtonDown(0))
		{
			if (Physics.Raycast(Camera.main.ScreenPointToRay(new Vector3(Input.mousePosition.x, Input.mousePosition.y,0)), out rayInfo)) {
				Instantiate(Town, rayInfo.point, Quaternion.identity);
			}
			}


	}

		
		
		void OnMouseDown(){
			
			
			
		}


	
}
