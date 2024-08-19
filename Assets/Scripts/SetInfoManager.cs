using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class SetInfoManager : MonoBehaviour
{
    [SerializeField] Image Background;
    [SerializeField] Image Header;
    [SerializeField] Image InfoImage;
    [SerializeField] TextMeshProUGUI NameInHeader;
    [SerializeField] TextMeshProUGUI NameInInfo;
    [SerializeField] TextMeshProUGUI CharFullInfo;
    void Start()
    {
        if(SelectAiManager.instance != null)
        {
            Background.sprite = SelectAiManager.instance.CurrentCharData.BluredImage;
            Header.sprite = SelectAiManager.instance.CurrentCharData.OriginalImage;
            SetCharFullInfo();
            NameInInfo.text = SelectAiManager.instance.CurrentCharData.CharacterAiName;
            NameInHeader.text = SelectAiManager.instance.CurrentCharData.CharacterAiName;
        }
    }
    private void SetCharFullInfo()
    {
        CharFullInfo.text = $"<b>Введение</b> \n \n {SelectAiManager.instance.CurrentCharData.CharShotDescription} " +
            $"\n\n<b>Описание</b> \n\n {SelectAiManager.instance.CurrentCharData.CharFullPromptDescription}\n\n " +
            $"<b>Приветствие</b> \n\n {SelectAiManager.instance.CurrentCharData.CharOpening}";
    }
}
