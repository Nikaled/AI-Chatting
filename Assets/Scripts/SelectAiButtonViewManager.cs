using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SelectAiButtonViewManager : MonoBehaviour
{
    [SerializeField] SelectAiButton[] AiButtons;
    [SerializeField] Image FemButton;
    [SerializeField] Image MaleButton;
    [SerializeField] Sprite FemButtonActive;
    [SerializeField] Sprite MaleButtonActive;
    [SerializeField] Sprite ButtonInactive;
    void Start()
    {
        /*for (int i = 0; i < AiButtons.Length; i++)
        {
            AiButtons[i].gameObject.SetActive(false);
        }*/
    }


    public void ShowFemale(bool Is)
    {
        for (int i = 0; i < AiButtons.Length; i++)
        {
            if(AiButtons[i].gender == SelectAiButton.Gender.Female)
            {
            AiButtons[i].gameObject.SetActive(Is);
            }
        }
        if (Is)
        {
            FemButton.sprite = FemButtonActive;
        }
        else
        {
            FemButton.sprite = ButtonInactive;
        }
    }
    public void ShowMale(bool Is)
    {
        for (int i = 0; i < AiButtons.Length; i++)
        {
            if (AiButtons[i].gender == SelectAiButton.Gender.Male)
            {
                AiButtons[i].gameObject.SetActive(Is);
            }
        }
        if (Is)
        {
            MaleButton.sprite = MaleButtonActive;
        }
        else
        {
            MaleButton.sprite = ButtonInactive;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
