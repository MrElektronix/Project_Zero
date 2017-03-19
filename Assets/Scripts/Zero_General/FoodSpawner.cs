using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawner : MonoBehaviour {

    [HideInInspector] private ClassControl _classControl;
    [SerializeField] private GameObject _food;
    private readonly float _spawntime;
    private float _minimumrange;
    private float _maximumrange;


    private void Start()
    {
        _classControl = GetComponent<ClassControl>();
        _minimumrange = -10.5f;
        _maximumrange = 10.5f;
    }

    public void SpawnNewFood()
    {

        var spawnPointX = Random.Range(_minimumrange, _maximumrange);
        var spawnPointY = 0.5f;
        var spawnPointZ = Random.Range(_minimumrange, _maximumrange);

        var spawnPointPosition = new Vector3(spawnPointX, spawnPointY, spawnPointZ);
        Instantiate(_food, spawnPointPosition, Quaternion.identity);
    }
}
