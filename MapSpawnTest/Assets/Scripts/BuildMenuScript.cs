using UnityEngine;
using System.Collections;

public class BuildMenuScript : MonoBehaviour {

	public GameObject buildmenu;
	public bool isClicked=false;
	public GameObject Town;
	private Vector3 place = new Vector3(0,0,0);
	private bool isShowing=false;
	 
	void Start(){

		//CickTest other = (CickTest) Click.GetComponent(typeof(CickTest));
	}
	void Update(){

		if (Input.GetKeyDown (KeyCode.Space)) {
			isShowing=true;
			print (isShowing);
				}

		buildmenu.SetActive(isShowing);
	
		}


}
