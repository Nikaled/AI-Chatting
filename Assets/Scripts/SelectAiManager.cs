using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class SelectAiManager : MonoBehaviour
{
    public static SelectAiManager instance;
    public string CharacterAiCode;
    public string CharacterAiName;
    public string CharOpening;
    public CharacterDataSO CurrentCharData;
    void Start()
    {
        if(instance == null)
        {
            instance = this;
        DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void OnSelectAiLogic(string AiCode, string AiName, string AiOpening, Sprite CharPortrait)
    {
        CharacterAiCode = AiCode;
        CharacterAiName = AiName;
        CharOpening = AiOpening;
        SceneManager.LoadScene(1);
    }
    public void OnSelectAiLogic(CharacterDataSO charData)
    {
        CharacterAiCode = charData.CharacterAiCode;
        CharacterAiName = charData.CharacterAiName;
        CharOpening = charData.CharOpening;
        CurrentCharData = charData;
        SceneManager.LoadScene(1);
    }
}
