/*using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float totalTime = 60f;  
    private float currentTime;     
    private bool timerRunning;    

    public TextMeshProUGUI timerText;         
    public GameObject panelToOpen; 
    public Button closeButton;     
    void Start()
    {
        currentTime = totalTime;
        timerRunning = true;

        if (closeButton != null)
        {
            closeButton.onClick.AddListener(ClosePanel);
        }
    }

    void Update()
    {
        if (timerRunning)
        {
            currentTime -= Time.deltaTime;

            if (currentTime <= 0)
            {
                currentTime = 0;
                timerText.color = Color.red;
                timerRunning = false;
                OpenPanel();
            }

            UpdateTimerDisplay();
        }
    }

    void UpdateTimerDisplay()
    {
        timerText.text = "00:" + Mathf.CeilToInt(currentTime).ToString();
    }

    void OpenPanel()
    {
        panelToOpen.SetActive(true);
    }

    void ClosePanel()
    {
        panelToOpen.SetActive(false);
    }
}*/
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float totalTime = 60f;
    private float currentTime;
    private bool timerRunning;
    private bool isPaused;  

    public TextMeshProUGUI timerText;
    public GameObject panelToOpen;
    public Button closeButton;
    public Button pauseButton;  
    public Button resumeButton; 


    void Start()
    {
        currentTime = totalTime;
        timerRunning = true;
        isPaused = false;

        if (closeButton != null)
        {
            closeButton.onClick.AddListener(ClosePanel);
        }

        if (pauseButton != null)
        {
            pauseButton.onClick.AddListener(PauseTimer);
        }

        if (resumeButton != null)
        {
            resumeButton.onClick.AddListener(ResumeTimer);
        }


        UpdateTimerDisplay();
    }

    void Update()
    {
        if (timerRunning && !isPaused)
        {
            currentTime -= Time.deltaTime;

            if (currentTime <= 0)
            {
                currentTime = 0;
                timerText.color = Color.red;
                timerRunning = false;
                OpenPanel(); 
            }

            UpdateTimerDisplay();
        }
    }

    void UpdateTimerDisplay()
    {
        timerText.text = "00:" + Mathf.CeilToInt(currentTime).ToString("00");
    }

    void OpenPanel()
    {
        if (panelToOpen != null)
        {
            panelToOpen.SetActive(true);
        }
    }

    void ClosePanel()
    {
        if (panelToOpen != null)
        {
            panelToOpen.SetActive(false);
        }
    }

    void PauseTimer()
    {
        isPaused = true;
        if (pauseButton != null)
        {
            pauseButton.interactable = false;  
            resumeButton.interactable = true;
        }
    }

    void ResumeTimer()
    {
        isPaused = false;
        if (pauseButton != null)
        {
            pauseButton.interactable = true;  
            resumeButton.interactable = false; 
        }
    }
}

