using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AddToCounter : MonoBehaviour
{
    public Button CounterUp;
    public int count;
    public TMP_Text countText;

    void Start()
    {
        count = 0;
        CounterUp.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        count++;
        countText.text = count.ToString();
    }

    void Update()
    {
        
    }
}
