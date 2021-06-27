using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeManager : MonoBehaviour
{
    DateTime StartTime = new DateTime();
    public static DateTime EndTime = new DateTime();
    public DateTime InternalEndTime = new DateTime();
    public static DateTime CurrentTime = new DateTime();

    public int RandomNumber;
    public static bool ActionActive;
    public bool InternalAction;

    public int scene;

    public GameObject button;

    void OnApplicationQuit()
    {
        Debug.Log("Quit time: "+DateTime.Now);
    }

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        scene = SceneManager.GetActiveScene().buildIndex;
        CurrentTime = DateTime.Now;

        if(ActionActive && CurrentTime >= EndTime)
        {
            RandomNumber = UnityEngine.Random.Range(-2000, 3000);
            GlobalCash.Cash += RandomNumber;
            ActionActive = false;
            if(scene == 6)
            {
                button.GetComponent<Button>().interactable = false;
                button.GetComponent<Image>().color = new Color (255,255,255,255);
            }
        }

        if(ActionActive && scene == 6)
        {
            button.GetComponent<Button>().interactable = false;
            button.GetComponent<Image>().color = new Color (90,100,100,255);
        }

        InternalAction = ActionActive;
        TimeData.ex_action_helper = InternalAction;
        
        InternalEndTime = EndTime;
        TimeData.ex_endtime_helper = InternalEndTime;
    }

    public void BuyAction()
    {
        if(GlobalCash.Cash >= 100)
        {
            Debug.Log("Action Bought");
            GlobalCash.Cash -= 100;
            StartTime = DateTime.Now;
            EndTime = StartTime.AddMinutes(40);
            ActionActive = true;
            button.GetComponent<Button>().interactable = false;
            button.GetComponent<Image>().color = new Color (90,100,100,255);
            Debug.Log("StartTime: "+StartTime);
            Debug.Log("EndTime: "+EndTime);
        }

    }
}
