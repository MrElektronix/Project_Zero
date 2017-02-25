using UnityEngine;
using UnityEngine.UI;

public class DisplayText : MonoBehaviour
{

    [SerializeField] private Text _energyText;
    [HideInInspector] public ZeroMain ZeroMain;

    private void Start()
    {
        ZeroMain = GetComponent<ZeroMain>();
    }


    private void Update()
    {
        _energyText.text = "Energy: " + ZeroMain.ZeroEnergy.Energy;
    }

}
