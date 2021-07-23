using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [Header("Parent Objects.")]
    [Tooltip("")] [SerializeField] private GameObject principalMenuParentObject;
    [Tooltip("")] [SerializeField] private GameObject gameParentObject;
    [Tooltip("")] [SerializeField] private GameObject gameOverParentObject;
    [Tooltip("")] [SerializeField] private GameObject settingsParentObject;
    [Tooltip("")] [SerializeField] private GameObject recordsParentObject;

    public void GoToGame()
    {
        if(principalMenuParentObject.activeSelf)
            principalMenuParentObject.SetActive(false);
        if (gameOverParentObject.activeSelf)
            gameOverParentObject.SetActive(false);
        gameParentObject.SetActive(true);
    }
    public void GoBackToMenu()
    {
        if (gameOverParentObject.activeSelf)
            gameOverParentObject.SetActive(false);
        if (settingsParentObject.activeSelf)
            settingsParentObject.SetActive(false);
        if (recordsParentObject.activeSelf) 
            recordsParentObject.SetActive(false);
        principalMenuParentObject.SetActive(true);
    }
    public void GoToSettingsMenu()
    {
        settingsParentObject.SetActive(true);
        principalMenuParentObject.SetActive(false);
    }

    public void GoToRecordMenu()
    {
        recordsParentObject.SetActive(true);
        principalMenuParentObject.SetActive(false);
    }

    public void GoToGameOver()
    {
        gameParentObject.SetActive(false);
        gameOverParentObject.SetActive(true);
    }
}
