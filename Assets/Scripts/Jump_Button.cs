using UnityEngine;
using UnityEngine.EventSystems;
public class Jump_Button : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    [HideInInspector]
    public bool press;

    public void OnPointerDown(PointerEventData eventData)
    {
        press = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        press = false;
    }
}
