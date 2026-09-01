using UnityEngine;
using UnityEngine.UI;
public class MuteClickHover : MonoBehaviour
{
    public Toggle mute;
    public AudioSource click;
    public AudioSource hover;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mute.onValueChanged.AddListener(delegate { OnToggleValueChanged(); });
    }

    void OnToggleValueChanged()
    {
        if (mute.isOn)
        {
            click.mute = false;
            hover.mute = false;
        }
        else
        {
            click.mute = true;
            hover.mute = true;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
