using UnityEngine;

public class ScreenSwitcher : MonoBehaviour
{
    public GameObject[] Screens;




    public void SwitchScreen()
    {
        foreach (GameObject objet in Screens)
        {
            objet.SetActive(false);
        }
    }

    public void Enable0()
    {
        SwitchScreen();
        Screens[0].SetActive(true);
    }

    public void Enable1()
    {
        SwitchScreen();
        Screens[1].SetActive(true);
    }
    public void Enable2()
    {
        SwitchScreen();
        Screens[2].SetActive(true);
    }
    public void Enable3()
    {
        SwitchScreen();
        Screens[3].SetActive(true);
    }
    public void Enable4()
    {
        SwitchScreen();
        Screens[4].SetActive(true);
    }
    public void Enable5()
    {
        SwitchScreen();
        Screens[5].SetActive(true);

    }

}
