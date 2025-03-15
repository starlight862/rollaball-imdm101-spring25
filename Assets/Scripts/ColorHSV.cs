using UnityEngine;
using UnityEngine.UI;

public class ColorHSV : MonoBehaviour
{

    float m_Hue;
    float m_Saturation;
    float m_Value;

    [Range(0.0f, 3.0f)]
    public float m_SliderHue, m_SliderSaturation, m_SliderValue;

    //Make sure your GameObject has a Renderer component in the Inspector window
    Renderer m_Renderer;

    void Start()
    {
        //Fetch the Renderer component from the GameObject with this script attached

        m_Renderer = GetComponent<Renderer>();
        m_SliderHue = 1;
        m_SliderSaturation = 1;
        m_SliderValue = 1;
    }

    void Update()
    {
        //These are the Sliders that determine the amount of the hue, saturation and value in the Color
        m_Hue = m_SliderHue;
        m_Saturation = m_SliderSaturation;
        m_Value = m_SliderValue;

        //Create an RGB color from the HSV values from the Sliders
        //Change the Color of your GameObject to the new Color
        m_Renderer.material.color = Color.HSVToRGB(m_Hue, m_Saturation, m_Value);

    }

}