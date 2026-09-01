using UnityEngine;
using UnityEngine.UI;

public class ExitGame : MonoBehaviour
{
    public Button exitButton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        exitButton.onClick.AddListener(QuitGame);
    }

    void QuitGame()
    {
        Debug.Log("Clicked Quit");
        Application.Quit();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
