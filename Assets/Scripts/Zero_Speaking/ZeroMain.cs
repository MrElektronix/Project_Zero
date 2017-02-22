
using UnityEngine;
using UnityEngine.UI;

public class ZeroMain : MonoBehaviour
{
    public InputField Input;
    [HideInInspector] public bool Walking;

    [HideInInspector] public ZeroWalk ZeroWalk;
    [HideInInspector] public UserInput UserInput;
    [HideInInspector] public ZeroLibrary ZeroLibrary;
    [HideInInspector] public ZeroRespond ZeroRespond;
    [HideInInspector] public DisplayText DisplayText;


    private void Awake()
    {
        ZeroWalk = GetComponent<ZeroWalk>();
        UserInput = GetComponent<UserInput>();
        ZeroLibrary = GetComponent<ZeroLibrary>();
        ZeroRespond = GetComponent<ZeroRespond>();
        DisplayText = GetComponent<DisplayText>();
    }

    private void Update()
    {
        Walking = !Input.isFocused;
    }
}
