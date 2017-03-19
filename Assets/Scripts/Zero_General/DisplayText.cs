using UnityEngine;
using UnityEngine.UI;

public class DisplayText : MonoBehaviour
{

    [SerializeField] private Text _energyText;
    [HideInInspector] private ClassControl _classControl;

    private void Start()
    {
        _classControl = GetComponent<ClassControl>();
    }


    private void Update()
    {
        _energyText.text = "Energy: " + _classControl.Energy.TotalEnergy;
    }

}
