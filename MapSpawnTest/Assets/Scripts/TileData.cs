using UnityEngine;
using System.Collections;

public class TileData : MonoBehaviour {
	public int DieNum;

	void Start () {
	
	}
	public void setNum(int i){
		DieNum=i;
		print(DieNum);
	}
}
