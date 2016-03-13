using UnityEngine;
using System.Collections;

public class MapGenArray : MonoBehaviour {
	Vector3 TilePos = new Vector3 (0, 0, 0);

	public GameObject[,] Tiles;
	public GameObject Tile;

	public GameObject[,] cTiles;
	public GameObject cTile;
	void Start () {
		Tiles = new GameObject[100,100];
		for (int x=0; x<100; x++) {
		for (int y=0; y<100; y++) {

				GameObject go = Instantiate(Tile, new Vector3(x*-10, 0, y*10), Quaternion.identity) as GameObject;
				Tiles[x,y] = go;

				GameObject cgo = Instantiate(Tile, new Vector3(x*-10, 0, y*10), Quaternion.identity) as GameObject;
				Tiles[x,y] = cgo;
						}
				}
	}
	

	void Update () {
	
	}
}
