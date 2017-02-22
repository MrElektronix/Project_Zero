using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// this handles the display of the text for zero and the user.
/// </summary>
public class DisplayText : MonoBehaviour
{

    [SerializeField] private Text _userText;
    [SerializeField] private Text _zeroText;

    public void WriteZeroText(string text)
    {
        _zeroText.text = "Zero: " + text;
    }

    public void WriteUserText(string text)
    {
        _userText.text = "User: " + text;
    }

}
