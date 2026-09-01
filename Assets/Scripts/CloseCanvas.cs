using UnityEngine;
using UnityEngine.UI;

public class CloseCanvas : MonoBehaviour
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
        subCanvas.enabled = false;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
