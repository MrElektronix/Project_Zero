using UnityEngine;

public class ZeroEnergy : MonoBehaviour
{

    [HideInInspector] public int Energy;
    private int _previousEnergy;
    private float _calculateEnergy;
    [HideInInspector] private ZeroMain _zeroMain;


    private void Awake()
    {
        Energy = 100;
        _previousEnergy = Energy;
    }

    private void Start()
    {
        _zeroMain = GetComponent<ZeroMain>();
        //_calculateEnergy = (Mathf.Round(_zeroMain.CalculateDistance.DistanceToObject) * 5);
    }

    private void Update()
    {


        if (Energy != _previousEnergy)
        {
            _zeroMain.FoodSpawner.SpawnNewFood();
            _previousEnergy = Energy;
        }

        if (Energy == 0)
        {
            _zeroMain.ZeroWalk.IsWalking = false;
        }
        else
        {
            _zeroMain.ZeroWalk.IsWalking = true;
        }

        //Debug.Log(_calculateEnergy);
        //Energy -= Mathf.RoundToInt(_calculateEnergy);
    }
}
