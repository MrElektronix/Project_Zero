using UnityEngine;

public class ZeroEnergy : MonoBehaviour
{

    [HideInInspector] public int Energy;
    [HideInInspector] private ZeroMain _zeroMain;

    private void Start()
    {
        Energy = 100;
        _zeroMain = GetComponent<ZeroMain>();
    }

    private void LateUpdate()
    {

    }
}
