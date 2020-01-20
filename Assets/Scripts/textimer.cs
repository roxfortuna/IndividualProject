using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;

public class textimer : MonoBehaviour
{
    public int timeLeft = 10;
    public Text countdown;

    // Use this for initialization
    void Start()
    {
        StartCoroutine("LoseTime");
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        countdown.text = ("" + timeLeft);

    }
    IEnumerator LoseTime()
    { while (true)
        { yield return new WaitForSeconds(1);
            timeLeft--;
        }
    }
     
}