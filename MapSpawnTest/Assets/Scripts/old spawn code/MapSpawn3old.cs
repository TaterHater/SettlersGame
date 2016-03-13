using UnityEngine;
using System.Collections;

public class MapSpawn3other : MonoBehaviour {
	
	
	// materials which are assigned to the materials int the editor
	public Material Desert;
	public Material Forest;
	public Material Brick;
	public Material Sheep;
	public Material Ore;
	public Material Wheat;
	public GameObject Tile;

	public const float TOTAL_TILES = 1200;
	//public const int ZERO = 
	public const double SPAWN_CHANCE = 4.0;
	public float SPREAD;
	public float xvec = 0;
	public float yvec = 0;
	public float zvec = 0;
	Vector3 TilePos = new Vector3 (0, 0, 0);
	public const float GENCONST = 0.5f;
    		
	//perfect, don't change
	private double desertCount = TOTAL_TILES / (SPAWN_CHANCE*2);
	private double forestCount = TOTAL_TILES / (SPAWN_CHANCE*1.2);
	private double sheepCount  = TOTAL_TILES / (SPAWN_CHANCE*1);
	private double brickCount  = TOTAL_TILES / (SPAWN_CHANCE*1.2);
	private double oreCount    = TOTAL_TILES / (SPAWN_CHANCE*1);
	private double wheatCount  = TOTAL_TILES / (SPAWN_CHANCE*2);

	private Vector3 seed1;
	private Vector3 seed2;
	private Vector3 seed3;
	private Vector3 seed4;
	private Vector3 seed5;
	private Vector3 seed6;
	private Vector3 seed7;
	private Vector3 seed8;
	private Vector3 seed9;
	private Vector3 seed10;
	private Vector3 seed11;
	private Vector3 seed12;
	private Vector3 seed13;
	private Vector3 seed14;
	private Vector3 seed15;
	private Vector3 seed16;
	private Vector3 seed17;
	private Vector3 seed18;
	private Vector3 seed19;
	public GameObject TC;
	private BoxCollider boxCollider;
	public bool isOk;


	void OnTriggerEnter(Collider other){
		isOk = false;
		print ("hit");
	}

	public  void SetTile(GameObject Tile, Vector3 seed){
		int locationType;
		int posx = 0;
		int posz = 0;
		int negx = 0;
		int negz = 0;
		int r = 0;
		int s = 0;
		int genVar = 0;
		float genTest = 0;
		xvec = 0; zvec = 0;
		locationType = Random.Range (0, 5);
		if (locationType == 0)
			desertCount--;
		if (locationType == 1)
			forestCount--;
		if (locationType == 2)
			brickCount--;
		if (locationType == 3)
			sheepCount--;
		if (locationType == 4)
			oreCount--;
		if (locationType == 5)
			wheatCount--;
			
		for (genVar = 0;genVar < 4;){
			if (genVar == 0){
				genTest += GENCONST;
				posx++;
			}
			if (genVar == 1){
				xvec -= 10;
				genTest += GENCONST;
				negx++;
			}
			if (genVar == 2){
				genTest += GENCONST;
				posz++;
			}
			if (genVar == 3){
				genTest += GENCONST;
				negz++;
			}
			if (Random.Range (0,100) < genTest){
				genVar++;
				genTest = 0;
			}
		} 
		bool isGen = false;
			for (int i = 0; i < TOTAL_TILES; i++) {
				do {
					switch (locationType) {
						case 0:
							Tile.GetComponent<Renderer>().material = Desert;
							Tile.tag = "desert";
							break;
						case 1:
							Tile.GetComponent<Renderer>().material = Forest;
							Tile.tag = "forest";
							break;
						case 2:
							Tile.GetComponent<Renderer>().material = Brick;
							Tile.tag = "brick";
							break;
						case 3:
							Tile.GetComponent<Renderer>().material = Sheep;
							Tile.tag = "sheep";
							break;
						case 4:
							Tile.GetComponent<Renderer>().material = Ore;
							Tile.tag = "ore";
							break;
						case 5:
							Tile.GetComponent<Renderer>().material = Wheat;
							Tile.tag = "wheat";
							break;
						default:
							break;
					}
				//yvec = (locationType * ((Mathf.Abs (xvec) / 10) + (Mathf.Abs (zvec) / 10)));
				yvec = Random.Range(0,4);
				TilePos = new Vector3 (xvec, yvec, zvec)+seed;
				boxCollider.center = TilePos;
			if (isOk && xvec >= 0 && zvec >=0){
				if ((Mathf.Pow(((xvec/10)/posx), 2) + Mathf.Pow(((zvec/10)/posz), 2)) <= 1){
					Instantiate (Tile, TilePos, Quaternion.Euler (0, 0, 0));
					isGen = true;
				}
			}
			else if (isOk && xvec < 0 && zvec >=0){
				if ((Mathf.Pow(((xvec/10)/negx), 2) + Mathf.Pow(((zvec/10)/posz), 2)) <= 1){
					Instantiate (Tile, TilePos, Quaternion.Euler (0, 0, 0));
					isGen = true;
				}
			}
			else if (isOk && xvec >= 0 && zvec < 0){
				if ((Mathf.Pow(((xvec/10)/posx), 2) + Mathf.Pow(((zvec/10)/negz), 2)) <= 1){
					Instantiate (Tile, TilePos, Quaternion.Euler (0, 0, 0));
					isGen = true;
				}
			}
			else if (isOk && xvec < 0 && zvec < 0){
				if ((Mathf.Pow(((xvec/10)/negx), 2) + Mathf.Pow(((zvec/10)/negz), 2)) <= 1){
					Instantiate (Tile, TilePos, Quaternion.Euler (0, 0, 0));
					isGen = true;
				}
			}
			if (isOk == false){
				isGen = true;
			}
			} while(isGen == false);

				if ((r+1) % 4 == 0){
					zvec += 10;
					s++;
				}
				else if (r % 2 == 1){
					zvec -= 10;
					s++;
				}
				else if (r % 4 == 0){
					xvec += 10;
					s++;
				}
				else {
					xvec -= 10;
					s++;
				}
				if ((s*2) >= r){
					s = 0;
					r++;
				}

/*				if (genVar == 0){
					xvec += 10;
					genTest += GENCONST;
					posx++;
				}
				if (genVar == 1){
					xvec -= 10;
					genTest += GENCONST;
					negx++;
				}
				if (genVar == 2){
					zvec += 10;
					genTest += GENCONST;
					posz++;
				}
				if (genVar == 3){
					zvec -= 10;
					genTest += GENCONST;
					negz++;
				}
				if (genVar == 4){
					if ((r+1) % 4 == 0){
						zvec += 10;
						s++;
					}
					else if (r % 2 == 1){
						zvec -= 10;
						s++;
					}
					else if (r % 4 == 0){
						xvec += 10;
						s++;
					}
					else {
						xvec -= 10;
						s++;
					}
					if ((s*2) >= r){
						s = 0;
						r++;
					}
				}
				if (Random.Range (0,100) < genTest){
					genVar++;
					xvec = 0;
					zvec = 0;
					genTest = 0;
				}
*/                         
			}
	}

	void Awake(){
		boxCollider = (BoxCollider)this.gameObject.GetComponent(typeof(BoxCollider));
	}
	//public void setGrassBase
	void Start(){
		SPREAD = (Mathf.Sqrt (TOTAL_TILES) * 10) - 100;

		seed1  = new Vector3 (       0, 0,        0);
		seed2  = new Vector3 (  SPREAD, 0,        0);
		seed3  = new Vector3 (2*SPREAD, 0,        0);
		seed4  = new Vector3 (       0, 0,   SPREAD);
		seed5  = new Vector3 (  SPREAD, 0,   SPREAD);
		seed6  = new Vector3 (2*SPREAD, 0,   SPREAD);
		seed7  = new Vector3 (       0, 0, 2*SPREAD);
		seed8  = new Vector3 (  SPREAD, 0, 2*SPREAD);
		seed9  = new Vector3 (2*SPREAD, 0, 2*SPREAD);
		seed10 = new Vector3 (       0, 0, 3*SPREAD);
		seed11 = new Vector3 (  SPREAD, 0, 3*SPREAD);
		seed12 = new Vector3 (2*SPREAD, 0, 3*SPREAD);
		seed13 = new Vector3 (3*SPREAD, 0, 3*SPREAD);
		seed14 = new Vector3 (3*SPREAD, 0, 2*SPREAD);
		seed15 = new Vector3 (3*SPREAD, 0,   SPREAD);
		seed16 = new Vector3 (3*SPREAD, 0,        0);

		xvec = transform.position.x;
		yvec = transform.position.z;

		StartCoroutine( CreateMap());

			
	}
	IEnumerator Wait(){
		yield return new WaitForSeconds(.5f);
		}

	IEnumerator CreateMap(){
		SetTile (Tile, seed1);
		StartCoroutine (Wait ());
		SetTile (Tile, seed2);
		StartCoroutine (Wait ());
		SetTile (Tile, seed3);
		StartCoroutine (Wait ());
		SetTile (Tile, seed4);
		StartCoroutine (Wait ());
		SetTile (Tile, seed5);
		StartCoroutine (Wait ());
		SetTile (Tile, seed6);
		StartCoroutine (Wait ());
		SetTile (Tile, seed7);
		StartCoroutine (Wait ());
		SetTile (Tile, seed8);
		StartCoroutine (Wait ());
		SetTile (Tile, seed9);
		StartCoroutine (Wait ());
		SetTile (Tile, seed10);
		StartCoroutine (Wait ());
		SetTile (Tile, seed11);
		StartCoroutine (Wait ());
		SetTile (Tile, seed12);
		StartCoroutine (Wait ());
		SetTile (Tile, seed13);
		StartCoroutine (Wait ());
		SetTile (Tile, seed14);
		StartCoroutine (Wait ());
		SetTile (Tile, seed15);
		StartCoroutine (Wait ());
		SetTile (Tile, seed16);
		StartCoroutine (Wait ());

		yield return new WaitForSeconds(0.1f);
	}
}