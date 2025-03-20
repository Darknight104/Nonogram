using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public AudioSource gameAudioSource;
    public GameObject panel;
    public Button musicButton;
    private bool isMuted = false;
    public GameObject panel2;
    public Button closeButton;
    public void OpenPanel2()
    {
        panel2.SetActive(true);
    }
    public void ClosePanel2()
    {
        panel2.SetActive(false);
    }
   
    private void Start()
    {
        gameAudioSource.Play();
        musicButton.onClick.AddListener(ToggleAudio);
    }

    private void ToggleAudio()
    {
        isMuted = !isMuted;

        if (isMuted)
        {
            gameAudioSource.volume = 0f;
           
        }
        else
        {
            gameAudioSource.volume = 1f;
            
        }
    }

    public void TogglePanel()
    {
        panel.SetActive(!panel.activeSelf);
    }
}
