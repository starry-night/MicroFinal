using UnityEngine;
using System.Collections;


public class StartGameFuntion : MonoBehaviour {

	public Transform redPrefab;
	public Transform bluePrefab;
	public Transform yellowPrefab;
	public Transform greenPrefab;
	public Transform orangePrefab;

	public int[] FinalColorNumber = new int[5];//0 orange,1 red,2 blue,3 yellow,4 green

	public Transform[] RandomPosition; // please put 12 position here;

	public TextMesh LevelNow;

	public bool gameActive;
	public int level =1;
	public int Current = 0;

	int[] numberOfEachColor = new int[5];
	int totalOfBox = 12;
	int totalOfColor = 5;

	public bool firstStart;
	public bool restart = true;

	// Use this for initialization
	void Start () {

		firstStart=false;
		if(restart){

			PlayerPrefs.DeleteAll();

		}else{
			if(!PlayerPrefs.HasKey("LevelNow")){
				PlayerPrefs.SetInt("LevelNow",1);
			}
			if(PlayerPrefs.GetInt("LevelNow")>1){
				firstStart = true;
			}
			if(PlayerPrefs.GetInt("LevelNow")==6){
				PlayerPrefs.DeleteAll();
				PlayerPrefs.SetInt("LevelNow",1);
			}
			level = PlayerPrefs.GetInt("LevelNow");
		}
	}


	void getStart(bool data){
		firstStart = data;
	}

	// Update is called once per frame
	void Update () {
		LevelNow.text = "Level:" +level;
		SendMessage ("Get", gameActive);

		if(Input.GetKeyDown ("r") && gameActive){
			Application.LoadLevel(Current);
		}
		
		if (Input.GetKeyDown ("r") && !gameActive||firstStart==true) {

			firstStart=false;
			gameActive=true;

			CreateNum();
			AssignColor();

			for(int i=1;i<=totalOfBox;i++){
				//Vector3 postion = new Vector3(((i-1)%4)*2.5f-2.5f,0,(Mathf.FloorToInt((i-1)/4))*2.5f);
				Vector3 postion = RandomPosition[i-1].position;
				int temp ;

				do{
					temp = Random.Range(0,100)%5;
				}while(FinalColorNumber[temp]==0);

				FinalColorNumber[temp]--;
			//	print (i);
			//	print (postion);
				switch(temp){
				case 0:
					Instantiate(orangePrefab, postion, Quaternion.identity);//print ("o");
					break;
				case 1:
					Instantiate(redPrefab, postion, Quaternion.identity);//print ("r");
					break;
				case 2:
					Instantiate(bluePrefab, postion, Quaternion.identity);//print ("b");
					break;
				case 3:
					Instantiate(yellowPrefab, postion, Quaternion.identity);//print ("y");
					break;
				case 4:
					Instantiate(greenPrefab, postion, Quaternion.identity);//print ("g");
					break;
				}
			}
		}
	
	}

	void CreateNum(){
		print ("level"+level);
		switch(level){
		case 1:
			numberOfEachColor = new int[]{1,2,3,3,3};
			break;
		case 2:
			numberOfEachColor = new int[]{4,1,3,2,2};
			break;
		case 3:
			numberOfEachColor = new int[]{4,1,1,3,3};
			break;
		case 4:
			numberOfEachColor = new int[]{4,4,1,1,2};
			break;
		case 5:
			numberOfEachColor = new int[]{4,4,0,4,0};
			break;
		default:
			break;
		}
	}

	void AssignColor(){
		int[] MarkThePosition = new int[]{0,0,0,0,0};
		for(int i=0;i<totalOfColor;i++){
			int temp ;
			do{
				temp = Random.Range(0,100)%5;
			}while(MarkThePosition[temp]!=0);
			FinalColorNumber[i] = numberOfEachColor[temp];
			MarkThePosition[temp] ++;
		}
		print ("Mark"+MarkThePosition);
	}


	
}