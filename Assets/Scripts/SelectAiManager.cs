using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SelectAiManager : MonoBehaviour
{
    public static SelectAiManager instance;
    public string CharacterAiCode;
    public string CharacterAiName;
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

    public void OnSelectAiLogic(string AiCode, string AiName)
    {
        CharacterAiCode = AiCode;
        CharacterAiName = AiName;

        SceneManager.LoadScene(1);
    }
}
