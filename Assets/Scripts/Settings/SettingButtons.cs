using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingButtons : MonoBehaviour
{
    [SerializeField] private GameObject[] languagesBtns = new GameObject[6];
    [SerializeField] private GameObject[] featuresBtns = new GameObject[6];
    [SerializeField] private AudioSource generalAudioSource;
    private void Awake()
    {
        UpdateFeaturesButtons();
        UpdateLanguageButtons();        
    }
    public void UpdateFeaturesBools(int id)
    {
        switch (id)
        {
            case 0:
                UserManager.soundOn = 1;
                PlayerPrefs.SetInt("SoundOnKey", 1);
                break;
            case 1:
                UserManager.musicOn = 1;
                PlayerPrefs.SetInt("MusicOnKey", 1);
                break;
            case 2:
                UserManager.vibrationOn = 1;
                PlayerPrefs.SetInt("VibrationKey", 1);
                break;
            case 3:
                UserManager.soundOn = 0;
                PlayerPrefs.SetInt("SoundOnKey", 0);
                break;
            case 4:
                UserManager.musicOn = 0;
                PlayerPrefs.SetInt("MusicOnKey", 0);
                break;
            case 5: 
                UserManager.vibrationOn = 0;
                PlayerPrefs.SetInt("VibrationKey", 0);
                break;
        }
    }

    public void UpdateFeaturesButtons()
    {
        if (UserManager.soundOn == 1)
        {
            featuresBtns[0].SetActive(true);
            featuresBtns[1].SetActive(false);
        }
        else
        {
            featuresBtns[1].SetActive(true);
            featuresBtns[0].SetActive(false);
        }

        if (UserManager.musicOn == 1)
        {
            featuresBtns[2].SetActive(true);
            featuresBtns[3].SetActive(false);
            generalAudioSource.Play();
        }
        else
        {
            featuresBtns[3].SetActive(true);
            featuresBtns[2].SetActive(false);
            generalAudioSource.Stop();
        }
        if (UserManager.vibrationOn == 1)
        {
            featuresBtns[4].SetActive(true);
            featuresBtns[5].SetActive(false);
        }
        else
        {
            featuresBtns[5].SetActive(true);
            featuresBtns[4].SetActive(false);
        }
    }
    public void UpdateLanguageBools(int id)
    {
        switch (id)
        {
            case 0:               
                UserManager.englishOn = 1;
                UserManager.chineseOn = 0;
                UserManager.russianOn = 0;
                PlayerPrefs.SetInt("EnglishKey", 1);
                PlayerPrefs.SetInt("ChineseKey", 0);
                PlayerPrefs.SetInt("RussianKey", 0);
                break;
            case 1:
                UserManager.englishOn = 0;
                UserManager.chineseOn = 0;
                UserManager.russianOn = 1;
                PlayerPrefs.SetInt("EnglishKey", 0);
                PlayerPrefs.SetInt("ChineseKey", 0);
                PlayerPrefs.SetInt("RussianKey", 1);
                break;
            case 2:
                UserManager.englishOn = 0;
                UserManager.chineseOn = 1;
                UserManager.russianOn = 0;
                PlayerPrefs.SetInt("EnglishKey", 0);
                PlayerPrefs.SetInt("ChineseKey", 1);
                PlayerPrefs.SetInt("RussianKey", 0);
                break;
        }
    }
    public void UpdateLanguageButtons()
    {
        if (UserManager.englishOn == 1)
        {
            languagesBtns[0].SetActive(true);
            languagesBtns[1].SetActive(false);
            languagesBtns[2].SetActive(false);
            languagesBtns[3].SetActive(true);
            languagesBtns[4].SetActive(false);
            languagesBtns[5].SetActive(true);
        }
        if (UserManager.russianOn == 1)
        {
            languagesBtns[0].SetActive(false);
            languagesBtns[1].SetActive(true);
            languagesBtns[2].SetActive(true);
            languagesBtns[3].SetActive(false);
            languagesBtns[4].SetActive(false);
            languagesBtns[5].SetActive(true);
        }
        if (UserManager.chineseOn == 1)
        {
            languagesBtns[0].SetActive(false);
            languagesBtns[1].SetActive(true);
            languagesBtns[2].SetActive(false);
            languagesBtns[3].SetActive(true);
            languagesBtns[4].SetActive(true);
            languagesBtns[5].SetActive(false);
        }
    }
}
