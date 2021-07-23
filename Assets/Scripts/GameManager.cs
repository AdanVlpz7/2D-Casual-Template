using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text cTxt;
    public Text RecordTxt;
    public Text HighRecordTxt;
    public bool gameIsOver = false;
    int c = 1;
    public int record = 0;
    private void OnEnable()
    {
        c = 1;
        record = 0;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            c++;
            cTxt.text = c.ToString();
            record++;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            c--;
            cTxt.text = c.ToString();
            record++;
        }
        if (c == 0)
        {
            if(CheckRecord(record))
                PlayerPrefs.SetInt("Record", record);
            ChangingRecordTxt(record);
            GameObject uiManager = GameObject.Find("UIManager");
            uiManager.GetComponent<UIManager>().GoToGameOver();

            gameIsOver = true;
        }
    }
    bool CheckRecord(int record)
    {
        if (record > PlayerPrefs.GetInt("Record"))            
            return true;
        else           
            return false;
    }
    void ChangingRecordTxt(int record)
    {
        RecordTxt.text = "Your score was: "+record.ToString();
        HighRecordTxt.text = "Your highScore is: " + PlayerPrefs.GetInt("Record").ToString();
    }
    
}
