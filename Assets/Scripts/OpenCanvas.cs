using UnityEngine;
using UnityEngine.UI;

public class OpenCanvas : MonoBehaviour
{
    public Canvas subCanvas;
    public Button thisButton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        thisButton.onClick.AddListener(Clicked);
    }

    void Clicked()
    {
        subCanvas.enabled = true;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
