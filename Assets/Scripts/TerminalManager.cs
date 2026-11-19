using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class TerminalManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI topText;
    [SerializeField] private TextMeshProUGUI infoText;
    [SerializeField] private TextMeshProUGUI plantText;
    [SerializeField] private TextMeshProUGUI hawkText;
    [SerializeField] private TextMeshProUGUI cmeText;

    [SerializeField] private Color green;

    [SerializeField] private Button CMEButton;
    [SerializeField] private Button chipButton;
    [SerializeField] private TextMeshProUGUI chipText;

    [TextArea] [SerializeField] private string topCollected;
    [TextArea] [SerializeField] private string infoCollected;

    [SerializeField] private InputActionReference plantInput;
    [SerializeField] private InputActionReference hawkInput;

    private bool plantDone = false;
    private bool hawkDone = false;
    private bool cmeDone = false;

    [SerializeField] private GameObject terminalScreen;
    [SerializeField] private GameObject CMEScreen;
    [SerializeField] private GameObject completeScreen;
    
    void Start()
    {
        chipButton.interactable = false;
        terminalScreen.SetActive(true);
        CMEScreen.SetActive(false);
        completeScreen.SetActive(false);
        chipText.color = Color.darkGray;
    }

    
    void Update()
    {
        if (plantInput.action.IsPressed() && !plantDone)
        {
            plantDone = true;
            PlantDone();
        }

        if (hawkInput.action.IsPressed() && !hawkDone)
        {
            hawkDone = true;
            HawkDone();
        }

        if (plantDone && hawkDone && cmeDone)
            ChipReady();
    }

    private void PlantDone()
    {
        plantText.color = green;
    }

    private void HawkDone()
    {
        hawkText.color = green;
    }

    public void ShowCMEScreen()
    {
        terminalScreen.SetActive(false);
        CMEScreen.SetActive(true);
    }

    public void ShowTerminalScreen()
    {
        terminalScreen.SetActive(true);
        CMEScreen.SetActive(false);
    }

    public void CMEDone()
    {
        cmeText.color = green;
        cmeDone = true;
    }

    private void ChipReady()
    {
        topText.text = topCollected;
        topText.color = green;
        infoText.text = infoCollected;
        chipButton.interactable = true;
        chipText.color = Color.white;
    }

    public void MakeChip()
    {
        terminalScreen.SetActive(false);
        CMEScreen.SetActive(false);
        completeScreen.SetActive(true);
    }
}
