using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapSystem : MonoBehaviour
{

    public int numOfChecks;
    public int currentCheck;
    public int numberOfLaps;
    public int currentLap;
    public string lapShow;

    public GameObject LapCounter;
    public GameObject LapTotal;

    public GameObject gameOver;
    // Start is called before the first frame update
    void Start()
    {
        numOfChecks = GameObject.Find ("Checkpoints").transform.childCount;
        currentCheck = 1;
        numberOfLaps = 2;
        currentLap = 1;
    }

    // Update is called once per frame
    void Update()
    {

        if(currentCheck > numOfChecks)
        {
            currentLap++;
            currentCheck = 1;
        }

        if(currentLap > numberOfLaps)
        {
            gameOver.SetActive(true);
            Time.timeScale = 0.0f;
        }

        LapCounter.GetComponent<Text>().text = "" + currentLap;
        LapTotal.GetComponent<Text>().text = "/" + numberOfLaps;
    }

    void OnTriggerEnter (Collider checkCollider)
    {
        if(checkCollider.name == currentCheck.ToString())
        {
            currentCheck++;
        }

        
    }
}
