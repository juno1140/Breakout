using UnityEngine;
using UnityEngine.UI;


public class TextDataFetcher : MonoBehaviour
{
    public Text resultMessageText;

    // Start is called before the first frame update
    void Start()
    {
        resultMessageText.text = DataSender.resultMessage;
    }
}
