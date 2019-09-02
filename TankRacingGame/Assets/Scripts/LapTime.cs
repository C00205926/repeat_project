using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapTime : MonoBehaviour
{

    public static int minCount;
    public static int secCount;
    public static float millCount;
    public static string millDisplay;

    public GameObject minBox;
    public GameObject secBox;
    public GameObject millBox;



    void Update()
    {
        millCount += Time.deltaTime *10;
        millDisplay = millCount.ToString("f0");
        millBox.GetComponent<Text>().text = "" + millDisplay;

        if(millCount >= 10)
        {
            millCount = 0;
            secCount += 1;
        }
        

        if(secCount<= 9)
        {
            secBox.GetComponent<Text>().text = "0" + secCount +".";
        }
        else
        {
            secBox.GetComponent<Text>().text = "" + secCount +".";
        }

        if(secCount >= 60)
        {
            secCount = 0;
            minCount += 1;
        }

        if(minCount<= 9)
        {
            minBox.GetComponent<Text>().text = "0" + minCount +":";
        }
        else
        {
            minBox.GetComponent<Text>().text = "" + minCount +":";
        }
    }
}
