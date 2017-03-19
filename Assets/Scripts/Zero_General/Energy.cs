using UnityEngine;

public class Energy : MonoBehaviour
{

    [HideInInspector] public int TotalEnergy;
    private int _previousEnergy;
    private float _calculateEnergy;
    [HideInInspector] private ClassControl _classControl;


    private void Awake()
    {
        TotalEnergy = 100;
        _previousEnergy = TotalEnergy;
    }

    private void Start()
    {
        _classControl = GetComponent<ClassControl>();
        //_calculateEnergy = (Mathf.Round(_zeroMain.CalculateDistance.DistanceToObject) * 5);
    }

    private void Update()
    {


        if (TotalEnergy != _previousEnergy)
        {
            _classControl.FoodSpawner.SpawnNewFood();
            _previousEnergy = TotalEnergy;
        }

        if (TotalEnergy == 0)
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
