using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public static Timer instance;

    void Awake()
    {
        instance = this;
    }

    public GameObject timesUpText;
    public GameObject youWinText;
    public float maxTime = 5f;
    public float timeLeft;
    public Task engine;
    public Task controls;

    public Text countdown;

    void Start()
    {
        //engine = GameObject.Find("Engine").GetComponent<Task>()
        //controls = GameObject.Find("Controls").GetComponent<Task>();
        engine.isComplete = false;
        controls.isComplete = false;
        timesUpText.SetActive(false);
        youWinText.SetActive(false);
        timeLeft = maxTime;
    }

    void Update()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
        }
        else
        {
            timesUpText.SetActive(true);
            Time.timeScale = 0;
        }
        if (engine.isComplete && controls.isComplete)
        {
            youWinText.SetActive(true);
            Time.timeScale = 0;
        }

        countdown.text = Mathf.Round(timeLeft).ToString();
    }
}
