using UnityEngine;
using TMPro;

public class ScreenSwitcher : MonoBehaviour
{
    public GameObject[] Screens;
    [SerializeField] private TextMeshProUGUI speedText;
    [SerializeField] private int[] Speeds;

    private void Start()
    {
        SwitchScreen();
    }

    public void SwitchScreen()
    {
        foreach (GameObject objet in Screens)
        {
            objet.SetActive(false);
        }
        speedText.SetText("");
    }

    public void Enable0()
    {
        SwitchScreen();
        Screens[0].SetActive(true);
        speedText.SetText($"{Speeds[0]} km/s");
    }

    public void Enable1()
    {
        SwitchScreen();
        Screens[1].SetActive(true);
        speedText.SetText($"{Speeds[1]} km/s");
    }
    public void Enable2()
    {
        SwitchScreen();
        Screens[2].SetActive(true);
        speedText.SetText($"{Speeds[2]} km/s");
    }
    public void Enable3()
    {
        SwitchScreen();
        Screens[3].SetActive(true);
        speedText.SetText($"{Speeds[3]} km/s");
    }
    public void Enable4()
    {
        SwitchScreen();
        Screens[4].SetActive(true);
        speedText.SetText($"{Speeds[4]} km/s");
    }
    public void Enable5()
    {
        SwitchScreen();
        Screens[5].SetActive(true);
        speedText.SetText($"{Speeds[5]} km/s");
    }
}
