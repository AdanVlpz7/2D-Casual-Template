using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Traductor : MonoBehaviour
{
    [SerializeField] private string englishTxt; 
    [SerializeField] private string chineseTxt; 
    [SerializeField] private string russianTxt; 

    public void TranslatingField()
    {
        if (UserManager.englishOn == 1)
            this.gameObject.GetComponent<Text>().text = englishTxt;
        if (UserManager.russianOn == 1)
            this.gameObject.GetComponent<Text>().text = russianTxt;
        if (UserManager.chineseOn == 1)
            this.gameObject.GetComponent<Text>().text = chineseTxt;
    }
}
