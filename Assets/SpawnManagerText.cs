using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SpawnManagerText : MonoBehaviour
{
    public Text xText;
    public Text yText;
    public Text zText;
    public static int xDimension;
    public static int yDimension;
    public static int zDimension;

    void Update(){
        string xString = xText.ToString();
        string yString = yText.ToString();
        string zString = zText.ToString();
        
        
        xDimension = int.Parse(xString);
        yDimension = int.Parse(yString);
        zDimension = int.Parse(zString);

    }
    



}
