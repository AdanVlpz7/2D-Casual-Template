using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserManager : MonoBehaviour
{
    public int score = 0;
    public List<int> HighScores = new List<int>();
    public static int vibrationOn = 1;
    public static int soundOn = 1; 
    public static int musicOn = 1;

    public static int englishOn = 1;
    public static int chineseOn = 0;
    public static int russianOn = 0;

    private void Awake()
    {
        LoadData();
        AudioSource generalAudio = this.GetComponent<AudioSource>();
        if (musicOn == 1)
            generalAudio.Play();
        else
            generalAudio.Stop();
    }

    private void LoadData()
    {
        score = PlayerPrefs.GetInt("Record");
        englishOn = PlayerPrefs.GetInt("EnglishKey");
        chineseOn = PlayerPrefs.GetInt("ChineseKey");
        russianOn = PlayerPrefs.GetInt("RussianKey");
        vibrationOn = PlayerPrefs.GetInt("VibrationKey");
        soundOn = PlayerPrefs.GetInt("SoundOnKey");
        musicOn = PlayerPrefs.GetInt("MusicOnKey");
    }
}
