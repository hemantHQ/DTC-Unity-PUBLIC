using UnityEngine;

public class Cylinder : MonoBehaviour
{
    public GameObject Next_Panel;
    public GameObject Over_Panel;
    public AudioSource Ball_Cylinder;

    public void Start()
    {
        Ball_Cylinder = GetComponent<AudioSource>();
    }
    public void Next()
    {
        Time.timeScale = 0f;
        Next_Panel.SetActive(true);
    }
    public void Dead()
    {
        Time.timeScale = 0f;
        Over_Panel.SetActive(true);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Finish"))
        {
            Next();
        }
        if (collision.gameObject.CompareTag("Respawn"))
        {
            Dead();
        }
        if (collision.gameObject.CompareTag("Ball"))
        {
            Ball_Cylinder.Play();
        }
    }
}