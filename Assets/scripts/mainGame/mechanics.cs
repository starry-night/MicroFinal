using UnityEngine;
using System.Collections;


public class mechanics : MonoBehaviour {
	public bool JumpScene = false;
	public int life =1000;
	public int endLevel = 1;
	public TextMesh Outcome ;
	public GameObject NextStage;

	//bool IsItShow = false;
	bool GameActive = false;
	bool ShowOutCome = false;

	// Use this for initialization
	void Start () {
		//Outcome.text = "Life: " + life;
	}
	
	// Update is called once per frame
	void Update () {
			UnBalanceLessPointMode ();
	}

	void Get(bool data){
		GameActive = data;
	}

	void UnBalanceLessPointMode(){								// the mode that you lose the point when you are unbalance
		GameObject[] red = GameObject.FindGameObjectsWithTag ("red");
		GameObject[] blue = GameObject.FindGameObjectsWithTag ("blue");
		GameObject[] yellow = GameObject.FindGameObjectsWithTag ("yellow");
		GameObject[] green = GameObject.FindGameObjectsWithTag ("green");
		GameObject[] orange = GameObject.FindGameObjectsWithTag ("orange");

//		print ("Here is New Round");
//
//		print ("red"+red.Length);
//		print ("blue"+blue.Length);
//		print ("yellow"+yellow.Length);
//		print ("green"+green.Length);
//		print ("orange"+orange.Length);

		if (life > 0 && GameActive) {
			//original prefab count as 1,so it has to be desired number +1, ie 3+1=4
			if (
				(red.Length > 4 || red.Length < 3||
				blue.Length > 4 || blue.Length < 3 ||
				yellow.Length > 4 || yellow.Length < 3 ||
				green.Length > 4 || green.Length < 3 ||
				orange.Length > 4 || orange.Length < 3) &&
				ShowOutCome == false
			    ) {
					if (red.Length>4){
						life -= 1;
					}
					if (red.Length<3){
						life -= 1;
					}
					if (blue.Length>4){
						life -= 1;
					}
					if (blue.Length<3){
						life -= 1;
					}
					if (yellow.Length>4){
						life -= 1;
					}
					if (yellow.Length<3){
						life -= 1;
					}
					if (green.Length>4){
						life -= 1;
					}
					if (green.Length<3){
						life -= 1;
					}
					if (orange.Length>4){
						life -= 1;
					}
					if (orange.Length<3){
						life -= 1;
					}
					
//				if(IsItShow){
//
//				}
				//Outcome.text="Life: " + life;
			}
			if((red.Length==3||red.Length==4)&&
			   (yellow.Length==4||yellow.Length==3)&&
			   (green.Length==4||green.Length==3)&&
			   (blue.Length==4||blue.Length==3)&&
			   (orange.Length==4||orange.Length==3)
			   ){
				//print ("trigger end in 42 ln");
				if(!ShowOutCome){
					END (true);
				}
			}
		} else if(life<=0) {
			//Game over
			if(!ShowOutCome){
			END (false);
			}
		}

		//Debug.Log (life);
	}



	void END(bool win){	//saving the data to next scene, BTW, it is not the good practice to do in playerpref.

		int nowScore;

		if(PlayerPrefs.HasKey("score")){
			nowScore = PlayerPrefs.GetInt("score");
		}else{
			nowScore = 0;
		}
		print(nowScore);
		nowScore = nowScore + life;

		PlayerPrefs.SetInt ("score", nowScore);

		if (win) {

				int next = PlayerPrefs.GetInt("LevelNow")+1;

				print ("next level"+ next);
				PlayerPrefs.SetInt("LevelNow",next);
			Outcome.text = " You Win! "+"\n"+" Level Score: "+ life +"\n"+" Total Score: " + nowScore ;
				NextStage.renderer.enabled = true;
				SendMessage("ENDShow",true);
			if(next==6){
				//PlayerPrefs.DeleteAll();
				Application.LoadLevel ("goodEnd");
			}

		} else {

			Outcome.text = " GAME OVER";
			PlayerPrefs.DeleteAll();
		}
		if (JumpScene && !win) {
			Application.LoadLevel ("gameOver");
		}
		ShowOutCome = true;
	}
}
