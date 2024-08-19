using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SelectAiButton : MonoBehaviour
{
    public string CharacterAiCode;
    public string CharacterAiName;
    public Gender gender;
    [SerializeField] TextMeshProUGUI CharName;
    [SerializeField] TextMeshProUGUI CharDesc;
    [TextArea(3, 10)]
    public string CharDescription;
    [TextArea(3, 10)]
    public string CharOpening;
    public Image CharPortrait;
    public CharacterDataSO CharData;
    public enum Gender
    {
        Male,
        Female
    }
    private void Start()
    {
        CharName.text = CharacterAiName;
        CharDesc.text = CharDescription;
        CharPortrait.sprite = CharData.OriginalImage;
    }
    public void CharacterSelectButton()
    {
        //SelectAiManager.instance.OnSelectAiLogic(CharacterAiCode, CharacterAiName, CharOpening, CharPortrait.sprite);
        SelectAiManager.instance.OnSelectAiLogic(CharData);
    }

}
