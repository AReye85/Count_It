using UnityEngine;
using UnityEngine.UI;

public class BackgroundSlider : MonoBehaviour
{
    public Slider backgroundSlider;
    public AudioSource backgroundAudio;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        backgroundSlider.value = backgroundAudio.volume;
        backgroundSlider.onValueChanged.AddListener(delegate { OnSliderValueChanged(); });
    }
    void OnSliderValueChanged()
    {
        backgroundAudio.volume = backgroundSlider.value;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
