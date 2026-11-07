using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DateMatcher : MonoBehaviour
{
    public TMP_InputField inputField;
    public GameObject errorText;
    public GameObject successText;

    public void checkInput()
    {
        string input = inputField.text;
        string correctDate = "07-05-2123";

        if (input == correctDate)
        {
            Debug.Log(input + " matches " + correctDate);
            successText.SetActive(true);

        }

        else
        {
            errorText.SetActive(true);
            Debug.Log(input + " does not match!");
        }


    }


}
