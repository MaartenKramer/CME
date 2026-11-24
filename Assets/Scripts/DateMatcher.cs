using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DateMatcher : MonoBehaviour
{
    [SerializeField] private TerminalManager terminalManager;

    public TMP_InputField inputField;
    [SerializeField] private GameObject sendButton;
    [SerializeField] private Image inputFieldLine;
    public GameObject errorText;
    public GameObject successText;

    [SerializeField] private Color baseColor;
    [SerializeField] private Color colorFailed;
    [SerializeField] private Color colorCorrect;

    [SerializeField] private string[] correctDateVersions;
    [SerializeField] private TextMeshProUGUI inputText;

    public void CheckInput()
    {
        string input = inputField.text;

        foreach (string dateVersion in correctDateVersions)
        {
            if (input == dateVersion)
            {
                Debug.Log(input + " matches " + dateVersion);
                inputField.textComponent.color = colorCorrect;
                inputFieldLine.color = colorCorrect;
                inputField.interactable = false;
                sendButton.SetActive(false);
                errorText.SetActive(false);
                successText.SetActive(true);
                terminalManager.CMEDone();
                return;
            }
            else
            {
                Debug.Log(input + " does not match!");
                inputField.textComponent.color = colorFailed;
                inputFieldLine.color = colorFailed;
            }
        }
    }

    public void WhenSelected()
    {
        inputField.textComponent.color = baseColor;
        inputFieldLine.color = baseColor;
    }
}
