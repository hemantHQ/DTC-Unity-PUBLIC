using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Levels : MonoBehaviour
{
    public AudioSource Click_Sound;
    private void Start()
    {
        Click_Sound = GetComponent<AudioSource>();
    }
    public void OpenLevel(int levelId)
    {
        string levelName = "Level_" + levelId;
        Click_Sound.Play();
        SceneManager.LoadScene(levelName);
    }
   
}
