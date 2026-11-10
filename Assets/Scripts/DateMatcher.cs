using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DateMatcher : MonoBehaviour
{
    public TMP_InputField inputField;
    [SerializeField] private GameObject sendButton;
    [SerializeField] private Image inputFieldLine;
    public GameObject errorText;
    public GameObject successText;

    [SerializeField] private Color baseColor;
    [SerializeField] private Color colorFailed;
    [SerializeField] private Color colorCorrect;

    [SerializeField] private string correctDate;

    public void checkInput()
    {
        string input = inputField.text;

        if (input == correctDate)
        {
            Debug.Log(input + " matches " + correctDate);
            inputField.textComponent.color = colorCorrect;
            inputFieldLine.color = colorCorrect;
            inputField.interactable = false;
            sendButton.SetActive(false);
            errorText.SetActive(false);
            successText.SetActive(true);
        }

        else
        {
            Debug.Log(input + " does not match!");
            inputField.textComponent.color = colorFailed;
            inputFieldLine.color = colorFailed;
        }


    }

    public void WhenSelected()
    {
        inputField.textComponent.color = baseColor;
        inputFieldLine.color = baseColor;
    }
}
