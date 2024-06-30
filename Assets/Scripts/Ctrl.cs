using UnityEngine;
using UnityEngine.UIElements;

public class Ctrl : MonoBehaviour
{
    public float Move_lr, Move_ud;
    private bool groundContact = false;
    protected Joystick mv_stick;
    protected Jump_Button button;
    protected bool Jump;
    public GameObject Over_Panel;
    private void Start()
    {
        mv_stick = FindAnyObjectByType<Joystick>();
        button = FindAnyObjectByType<Jump_Button>();
    }
    void Update()
    {
        if (!Jump && button.press && groundContact)
        { 
            Jump = true;
            groundContact = true;
            GetComponent<Rigidbody>().velocity = Vector3.up*11;  
        }
        if (groundContact && Input.GetKeyDown(KeyCode.Space))
        {
            groundContact = true;
            GetComponent<Rigidbody>().velocity += Vector3.up * 11;
        }
        if (Jump && !button.press)
        {
            Jump= false;
        }

        Move_lr = Input.GetAxis("Horizontal");
        Move_ud = Input.GetAxis("Vertical");
        Vector3 inputDirection = new Vector3(mv_stick.Vertical * 5 + Move_ud * 5, GetComponent<Rigidbody>().velocity.y, -mv_stick.Horizontal * 5 + (-Move_lr * 5));
        GetComponent<Rigidbody>().velocity = inputDirection;

    }
    public void Dead()
    {
        Time.timeScale = 0f;
        Over_Panel.SetActive(true);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            groundContact = true;
        }

        if (collision.gameObject.CompareTag("Finish"))
        {
            Dead();
        }
        if (collision.gameObject.CompareTag("Respawn"))
        {
            Dead();
        }
        
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            groundContact = false;
        }
    }

}
