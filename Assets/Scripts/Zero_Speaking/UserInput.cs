using UnityEngine;

/// <summary>
/// This handles the input that comes in the InputField from the user.
/// </summary>
public class UserInput : MonoBehaviour
{
    public string Message;

    private ZeroMain _zeroMain;

    private void Start()
    {
        _zeroMain = GetComponent<ZeroMain>();
    }

    public void SetMessage()
    {
        Message = _zeroMain.Input.text;
        if (Message == "") {return;}

        _zeroMain.Input.text = "";
        _zeroMain.ZeroRespond.CheckMessage(Message);
    }
}
