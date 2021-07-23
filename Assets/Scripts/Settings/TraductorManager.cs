using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TraductorManager : MonoBehaviour
{
    [SerializeField] private Text[] textFields;
    private void Awake()
    {
        TranslatingTxt();
    }
    public void TranslatingTxt()
    {
        for (int i = 0; i < textFields.Length; i++)
        {
            textFields[i].GetComponent<Traductor>().TranslatingField();
        }
    }
}
