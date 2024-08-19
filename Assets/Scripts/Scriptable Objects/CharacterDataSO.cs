using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CharacterData", menuName = "ScriptableObjects/CharacterData", order = 52)]
public class CharacterDataSO : ScriptableObject
{
    public Sprite OriginalImage;
    public Sprite BluredImage;
    public string CharacterAiCode;
    public string CharacterAiName;
    public SelectAiButton.Gender gender;
    [TextArea(3, 10)]
    public string CharShotDescription;
    [TextArea(3, 10)]
    public string CharOpening;
    [TextArea(6, 30)]
    public string CharFullPromptDescription;
}
