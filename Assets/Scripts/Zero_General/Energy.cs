using UnityEngine;

public class Energy : MonoBehaviour
{

    [HideInInspector] private int _totalEnergy;
    private int _previousEnergy;
    private float _calculateEnergy;
    [HideInInspector] private ClassControl _classControl;


    private void Awake()
    {
        _totalEnergy = 100;
        _previousEnergy = _totalEnergy;
    }

    private void Start()
    {
        _classControl = GetComponent<ClassControl>();
        //_calculateEnergy = (Mathf.Round(_zeroMain.CalculateDistance.DistanceToObject) * 5);
    }

    public int TotalEnergy
    {
        get
        {
            return _totalEnergy;
        }
        set
        {
            if (_totalEnergy <= 0)
            {
                _totalEnergy = 0;
            } else if (_totalEnergy > 100)
            {
                _totalEnergy = 100;
            }
            else
            {
                _totalEnergy = value;
            }

        }
    }

    private void Update()
    {
        if (_totalEnergy != _previousEnergy)
        {
            _classControl.FoodSpawner.SpawnNewFood();
            _previousEnergy = _totalEnergy;
        }

        if (_totalEnergy == 0)
        {
            _classControl.Walk.IsWalking = false;
        }
        else
        {
            _classControl.Walk.IsWalking = true;
        }

        //Debug.Log(_calculateEnergy);
        //Energy -= Mathf.RoundToInt(_calculateEnergy);
    }
}
