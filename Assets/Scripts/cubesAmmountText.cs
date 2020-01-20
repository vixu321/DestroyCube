using UnityEngine.UI;
using UnityEngine;

[RequireComponent(typeof(Text))]
public class cubesAmmountText : MonoBehaviour {

	private Text cubesAmmount;
	void Awake(){
		cubesAmmount=GetComponent<Text>();
	}

	void Update(){
		cubesAmmount.text ="Red cubes: " + CubeGenerator.cubesOne.ToString() + "\nYellow cubes: " + CubeGenerator.cubesTwo.ToString() + "\nBlue cubes: " + CubeGenerator.cubesThree.ToString();
	}
}