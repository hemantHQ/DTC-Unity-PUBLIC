using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.UI;
using UnityEngine.UIElements;
public class Main_Menu : MonoBehaviour
{
    [SerializeField] GameObject Menu_Main;
    [SerializeField] GameObject Start_Button;
    [SerializeField] GameObject Option_Button;
    [SerializeField] GameObject Option_Music;
    [SerializeField] GameObject Option_Graphics;
    [SerializeField] GameObject Option_Controls;
    [SerializeField] GameObject Option_Credits;
    [SerializeField] GameObject Exit_Button;
    [SerializeField] GameObject AudioON;
    public AudioSource Button_Sound;
    public AudioMixer Effects;
    public bool lights=true;
    private void Start()
    {
        Button_Sound = GetComponent<AudioSource>();
        Application.targetFrameRate = 60;
        Screen.SetResolution(Screen.width, Screen.height, Screen.fullScreen);
    }
    public void SetEffectsVolume(float ffects)
    {
        Effects.SetFloat("Sound_Effects", ffects);
    }

    public void Play()
    {
        Button_Sound.Play();
        Menu_Main.SetActive(false);
        Option_Button.SetActive(false);
        Start_Button.SetActive(true);
    }
    public void Options()
    {
        Button_Sound.Play();
        Menu_Main.SetActive(false);
        Start_Button.SetActive(false);
        Option_Button.SetActive(true);
    }
    public void Exit()
    {
        Button_Sound.Play();
        Menu_Main.SetActive(false);
        Start_Button.SetActive(false);
        Option_Button.SetActive(false);
        Exit_Button.SetActive(true);
    }
    public void Exit_No()
    {
        Button_Sound.Play();
        Exit_Button.SetActive(false);
        Menu_Main.SetActive(true);
    }
    public void Exit_Yes()
    {
        Button_Sound.Play();
        Application.Quit();
    }
    public void Back_Options()
    {
        Button_Sound.Play();
        Option_Button.SetActive(false);
        Start_Button.SetActive(false);
        Menu_Main.SetActive(true);
    }
    public void MGCC_BACK()
    {
        Button_Sound.Play();
        Option_Music.SetActive(false);
        Option_Graphics.SetActive(false);
        Option_Controls.SetActive(false);
        Option_Credits.SetActive(false);
        Option_Button.SetActive(true);
    }
    public void Music()
    {
        Button_Sound.Play();
        Option_Button.SetActive(false);
        Option_Music.SetActive(true);
    }
    public void Graphics()
    {
        Button_Sound.Play();
        Option_Button.SetActive(false);
        Option_Graphics.SetActive(true);
    }
    public void Controls()
    {
        Button_Sound.Play();
        Option_Button.SetActive(false);
        Option_Controls.SetActive(true);
    }
    public void Credits()
    {
        Button_Sound.Play();
        Option_Button.SetActive(false);
        Option_Credits.SetActive(true);
    }
    public void fps60()
    {
        Application.targetFrameRate = 60;
    }
    public void fps90()
    {
        Application.targetFrameRate = 90;
    }
    public void fps120()
    {
        Application.targetFrameRate = 120;
    }
    public void fps240()
    {
        Application.targetFrameRate = 240;
    }
    public void Shadow_on()
    {
       lights = true;
    }
    public void Shadow_off()
    {
        lights = false;
    }

    public void audio_on()
    {
        AudioON.SetActive(true);
    }
    public void audio_off()
    {
        AudioON.SetActive(false);
    }
}
