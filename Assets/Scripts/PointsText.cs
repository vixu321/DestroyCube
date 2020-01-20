using UnityEngine.UI;
using UnityEngine;

[RequireComponent(typeof(Text))]
public class PointsText : MonoBehaviour {

	private Text pointsText;
	void Awake(){
		pointsText=GetComponent<Text>();
	}

	void Update(){
		pointsText.text ="Punkty: " + GameMaster.points.ToString();
	}
}
