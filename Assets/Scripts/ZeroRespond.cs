using UnityEngine;

/// <summary>
/// this handles the respond which takes the input from the user looks at it and responds back with something from his library.
/// </summary>
public class ZeroRespond : MonoBehaviour
{

    private ZeroMain _zeroMain;

    private void Start()
    {
        _zeroMain = GetComponent<ZeroMain>();
        WriteMessage();
    }

    public void WriteMessage()
    {
        _zeroMain.DisplayText.WriteZeroText(_zeroMain.ZeroLibrary.Questions[0]);
    }

    public void CheckMessage(string message)
    {
        _zeroMain.ZeroLibrary.UserAnswers.Add(message);
        if (_zeroMain.ZeroLibrary.UserAnswers.Count <= 0 && _zeroMain.ZeroLibrary.Questions.Count <= 0) return;
        for (var i = 0; i < _zeroMain.ZeroLibrary.Questions.Count;)
        {
            if (_zeroMain.ZeroLibrary.Questions[i] == null && _zeroMain.ZeroLibrary.UserAnswers[i] == null)
            {
                i--;
            }
            
            if (_zeroMain.ZeroLibrary.UserAnswers[i] != null)
            {
                _zeroMain.DisplayText.WriteUserText(_zeroMain.ZeroLibrary.UserAnswers[i]);
                i++;
                _zeroMain.DisplayText.WriteZeroText(_zeroMain.ZeroLibrary.Questions[i]);
            }
        }
    }


    /*
    public void ReadMessage()
    {
        for (var i = 0; i < _zeroMain.ZeroLibrary.UserWords.Count(); i++)
        {
            if (_zeroMain.UserInput.Message.ToLower() == _zeroMain.ZeroLibrary.UserWords[i])
            {
                _zeroMain.DisplayText.WriteZeroText(_zeroMain.ZeroLibrary.Answers[i]);
            }

        }
    }
    */

}
