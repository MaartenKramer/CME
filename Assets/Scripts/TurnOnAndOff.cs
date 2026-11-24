using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class TurnOnAndOff : MonoBehaviour
{
    [SerializeField] private bool use;

    [SerializeField] private InputActionReference generatorOnInput;
    [SerializeField] private GameObject noPowerCoronagraph;
    [SerializeField] private GameObject noPowerTerminal;

    [SerializeField] private Button[] coronagraphButtons;

    void Start()
    {
        if (use)
            TurnEverythingOff();
    }

    void Update()
    {
        if (generatorOnInput.action.IsPressed() && use)
            GeneratorOn();
    }

    private void TurnEverythingOff()
    {
        noPowerCoronagraph.SetActive(true);
        noPowerTerminal.SetActive(true);

        foreach (Button button in coronagraphButtons)
        {
            button.enabled = false;
        }
    }

    private void GeneratorOn()
    {
        noPowerCoronagraph.SetActive(false);
        noPowerTerminal.SetActive(false);

        foreach (Button button in coronagraphButtons)
        {
            button.enabled = true;
        }
    }
}
