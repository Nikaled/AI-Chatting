using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectAiButton : MonoBehaviour
{
    public string CharacterAiCode;
    public string CharacterAiName;
    public void CharacterSelectButton()
    {
        SelectAiManager.instance.OnSelectAiLogic(CharacterAiCode, CharacterAiName);
    }
}
