using UnityEngine;
using UnityEngine.SceneManagement;
public class Pause_Next_Menu : MonoBehaviour
{
    [SerializeField] GameObject Pause_Button;
    public AudioSource Sound;
    private void Start()
    {
        Sound=GetComponent<AudioSource>();
    }
    public void Pause()
    {
        Sound.Play();
        Pause_Button.SetActive(true);
        Time.timeScale =0f;
    }

    public void Resume()
    {
        Sound.Play();
        Pause_Button.SetActive(false);
        Time.timeScale = 1f;
    }
    public void retry()
    {
        Sound.Play();
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Next_Level()
    {
        Sound.Play();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        Time.timeScale = 1f;
    }
    public void Home()
    {
        Sound.Play();
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
}
