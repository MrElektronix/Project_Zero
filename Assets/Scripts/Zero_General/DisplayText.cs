using UnityEngine;
using UnityEngine.UI;

public class DisplayText : MonoBehaviour
{

    [SerializeField] private Text _text;
    [HideInInspector] private ClassControl _classControl;

    private void Start()
    {
        _classControl = GetComponent<ClassControl>();
    }


    public Text EnergyText
    {
        get
        {
            return _text;
        }
        set
        {
            _text = value;
        }
    }

    private void Update()
    {
        //_energyText.text = "Energy: " + _classControl.Energy.TotalEnergy;

    }

}
