using UnityEngine;
using System.Collections;

public class MapSpawn2 : MonoBehaviour {


	// materials which are assigned to the materials int the editor
	public Material Desert;
	public Material Forest;
	public Material Brick;
	public Material Sheep;
	public Material Ore;
	public Material Wheat;
	public Material Menu;
	// each tile in unity will be called into the code here ex(Tile1=Location1)
	public GameObject Location1;
	public GameObject Location2;
	public GameObject Location3;
	public GameObject Location4;
	public GameObject Location5;
	public GameObject Location6;
	public GameObject Location7;
	public GameObject Location8;
	public GameObject Location9;
	public GameObject Location10;
	public GameObject Location11;
	public GameObject Location12;
	public GameObject Location13;
	public GameObject Location14;
	public GameObject Location15;
	public GameObject Location16;
	public GameObject Location17;
	public GameObject Location18;
	public GameObject Location19;
	
	public int locTypeCur;
	public int dieCountCur;
	
	public int loc1Type;
	public int loc2Type;
	public int loc3Type;
	public int loc4Type;
	public int loc5Type;
	public int loc6Type;
	public int loc7Type;
	public int loc8Type;
	public int loc9Type;
	public int loc10Type;
	public int loc11Type;
	public int loc12Type;
	public int loc13Type;
	public int loc14Type;
	public int loc15Type;
	public int loc16Type;
	public int loc17Type;
	public int loc18Type;
	public int loc19Type;

	public int loc1Dice;
	public int loc2Dice;
	public int loc3Dice;
	public int loc4Dice;
	public int loc5Dice;
	public int loc6Dice;
	public int loc7Dice;
	public int loc8Dice;
	public int loc9Dice;
	public int loc10Dice;
	public int loc11Dice;
	public int loc12Dice;
	public int loc13Dice;
	public int loc14Dice;
	public int loc15Dice;
	public int loc16Dice;
	public int loc17Dice;
	public int loc18Dice;
	public int loc19Dice;

	//perfect, don't change
	private int desertCount = 1;
	private int forestCount = 4;
	private int sheepCount  = 4;
	private int brickCount  = 3;
	private int oreCount    = 3;
	private int wheatCount  = 4;
	
	private int dieCount2 = 1;
	private int dieCount3 = 2;
	private int dieCount4 = 2;
	private int dieCount5 = 2;
	private int dieCount6 = 2;
	private int dieCount8 = 2;
	private int dieCount9 = 2;
	private int dieCount10 = 2;
	private int dieCount11 = 2;
	private int dieCount12 = 1;

	public  void SetTile(GameObject Tile){
		
		int locationType;
		//bool isFinished=false;
		bool isGen=false;
		
		do {	
			locationType = Random.Range (0, 6);
			switch (locationType) {
				
			case 0:	
				if (desertCount == 1) {
					Tile.GetComponent<Renderer>().material = Desert;
					desertCount--;
					locTypeCur = 0;
					isGen = true;
					Tile.tag = "desert";
				} else {
					locationType = Random.Range (0, 6);
				}
				break;
			case 1:
				if (forestCount >= 1) {
					Tile.GetComponent<Renderer>().material = Forest;
					forestCount--;
					locTypeCur = 1;
					isGen = true;
					Tile.tag = "forest";
				} else {
					locationType = Random.Range (0, 6);
				}
				break;
			case 2:
				if (brickCount >= 1) {
					Tile.GetComponent<Renderer>().material =Brick;
					brickCount--;
					locTypeCur = 2;
					isGen = true;
					Tile.tag = "brick";
				} else {
					locationType = Random.Range (0, 6);
				}
				break;
			case 3:
				if (sheepCount >= 1) {
					Tile.GetComponent<Renderer>().material = Sheep;
					sheepCount--;
					locTypeCur = 3;
					isGen = true;
					Tile.tag = "sheep";
				} else {
					locationType = Random.Range (0, 6);
				}
				break;
			case 4:
				if (oreCount >= 1) {
					Tile.GetComponent<Renderer>().material = Ore;
					oreCount--;
					locTypeCur = 4;
					isGen = true;
					Tile.tag = "ore";
				} else {
					locationType = Random.Range (0, 6);
				}
				break;
			case 5:
				if (wheatCount >= 1) {
					Tile.GetComponent<Renderer>().material = Wheat;
					wheatCount--;
					locTypeCur = 5;
					isGen = true;
					Tile.tag = "wheat";
				} else {
					locationType = Random.Range (0, 6);
				}
				break;
			default:
				locationType = Random.Range (0, 6);
				break;
			}
		} while(isGen==false);		
		
		
		
	}
	
	public void giveValue(GameObject Tile){
		 

		bool isValued = false;
		int tileValueTest;

		if (locTypeCur == 0){
			isValued = true;
			dieCountCur = 0;
		}
		while (isValued == false){
			tileValueTest = Random.Range(1,13);
			switch (tileValueTest){
			case 2:
				if(dieCount2 > 0){
					Tile.GetComponent<TileData>().setNum(2);;
					dieCountCur = tileValueTest;
					dieCount2--;
					isValued = true;
				}
				else{
					tileValueTest = Random.Range(1,13);
				}
				break;
			case 3:
				if(dieCount3 > 0){
					Tile.GetComponent<TileData>().setNum(3);
					dieCountCur = tileValueTest;
					dieCount3--;
					isValued = true;
				}
				else{
					tileValueTest = Random.Range(1,13);
				}
				break;
			case 4:
				if(dieCount4 > 0){
					Tile.GetComponent<TileData>().setNum(4);
					dieCountCur = tileValueTest;
					dieCount4--;
					isValued = true;
				}
				else{
					tileValueTest = Random.Range(1,13);
				}
				break;
			case 5:
				Tile.GetComponent<TileData>().setNum(5);
				if(dieCount5 > 0){
					dieCountCur = tileValueTest;
					dieCount5--;
					isValued = true;
				}
				else{
					tileValueTest = Random.Range(1,13);
				}
				break;
			case 6:
				if(dieCount6 > 0){
					Tile.GetComponent<TileData>().setNum(6);
					dieCountCur = tileValueTest;
					dieCount6--;
					isValued = true;
				}
				else{
					tileValueTest = Random.Range(1,13);
				}
				break;
			case 8:
				if(dieCount8 > 0){
					Tile.GetComponent<TileData>().setNum(8);
					dieCountCur = tileValueTest;
					dieCount8--;
					isValued = true;
				}
				else{
					tileValueTest = Random.Range(1,13);
				}
				break;
			case 9:
				if(dieCount9 > 0){
					Tile.GetComponent<TileData>().setNum(9);
					dieCountCur = tileValueTest;
					dieCount9--;
					isValued = true;
				}
				else{
					tileValueTest = Random.Range(1,13);
				}
				break;
			case 10:
				if(dieCount10 > 0){
					Tile.GetComponent<TileData>().setNum(10);
					dieCountCur = tileValueTest;
					dieCount10--;
					isValued = true;
				}
				else{
					tileValueTest = Random.Range(1,13);
				}
				break;
			case 11:
				if(dieCount11 > 0){
					Tile.GetComponent<TileData>().setNum(11);
					dieCountCur = tileValueTest;
					dieCount11--;
					isValued = true;
				}
				else{
					tileValueTest = Random.Range(1,13);
				}
				break;
			case 12:
				if(dieCount12 > 0){
					Tile.GetComponent<TileData>().setNum(12);
					dieCountCur = tileValueTest;
					dieCount12--;
					isValued = true;
				}
				else{
					tileValueTest = Random.Range(1,13);
				}
				break;
			default:
				tileValueTest = Random.Range(1,13);
				break;
			}
		}
	}
	void Start () {
		// runs code that tells each tile what its type is and what texture to have
		SetTile (Location1);
		loc1Type = locTypeCur;
		giveValue (Location1);
		loc1Type = dieCountCur;

		SetTile (Location2);
		loc2Type = locTypeCur;
		giveValue (Location2);
		loc2Dice = dieCountCur;

		SetTile (Location3);
		loc3Type = locTypeCur;
		giveValue (Location3);
		loc3Dice = dieCountCur;

		SetTile (Location4);
		loc4Type = locTypeCur;
		giveValue (Location4);
		loc4Dice = dieCountCur;

		SetTile (Location5);
		loc5Type = locTypeCur;
		giveValue (Location5);
		loc5Dice = dieCountCur;

		SetTile (Location6);
		loc6Type = locTypeCur;
		giveValue (Location6);
		loc6Dice = dieCountCur;

		SetTile (Location7);
		loc7Type = locTypeCur;
		giveValue (Location7);
		loc7Dice = dieCountCur;

		SetTile (Location8);
		loc8Type = locTypeCur;
		giveValue (Location8);
		loc8Dice = dieCountCur;

		SetTile (Location9);
		loc9Type = locTypeCur;
		giveValue (Location9);
		loc9Dice = dieCountCur;

		SetTile (Location10);
		loc10Type = locTypeCur;
		giveValue (Location10);
		loc10Dice = dieCountCur;

		SetTile (Location11);
		loc11Type = locTypeCur;
		giveValue (Location11);
		loc11Dice = dieCountCur;

		SetTile (Location12);
		loc12Type = locTypeCur;
		giveValue (Location12);
		loc12Dice = dieCountCur;

		SetTile (Location13);
		loc13Type = locTypeCur;
		giveValue (Location13);
		loc13Dice = dieCountCur;

		SetTile (Location14);
		loc14Type = locTypeCur;
		giveValue (Location14);
		loc14Dice = dieCountCur;

		SetTile (Location15);
		loc15Type = locTypeCur;
		giveValue (Location15);
		loc15Dice = dieCountCur;

		SetTile (Location16);
		loc16Type = locTypeCur;
		giveValue (Location16);
		loc16Dice = dieCountCur;

		SetTile (Location17);
		loc17Type = locTypeCur;
		giveValue (Location17);
		loc17Dice = dieCountCur;

		SetTile (Location18);
		loc18Type = locTypeCur;
		giveValue (Location18);
		loc18Dice = dieCountCur;

		SetTile (Location19);
		loc19Type = locTypeCur;
		giveValue (Location19);
		loc19Dice = dieCountCur;
	}
	
	
	

}
