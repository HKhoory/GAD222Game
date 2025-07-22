using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ChangeSliderValue : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    [SerializeField] private Slider slider;
    [SerializeField] private float sliderValue;
    [SerializeField] private bool increaseValue;

    // Start is called before the first frame update
    void Start()
    {
        increaseValue = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (increaseValue)
        {
            slider.value += sliderValue * Time.deltaTime;
        }
    }

    public void OnPointerDown(PointerEventData button)
    {
        increaseValue = true;
    }

    public void OnPointerUp(PointerEventData button)
    {
        increaseValue = false;
    }

}
