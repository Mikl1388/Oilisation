using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Model : MonoBehaviour
{
    public float TickDuration;

    [SerializeField]
    private Building[] buildings;
    [SerializeField]
    private GameObject buildingsList;

    private void Start()
    {
        buildings = buildingsList.GetComponentsInChildren<Building>();
        foreach (Building building in buildings) { Debug.Log(building.gameObject.name); }
        StartCoroutine(Tick());
    }

    void Update()
    {
        
    }

    private void Simulate() 
    { 
        foreach (var building in buildings) { building.ExecuteOperation(); }
    }

    private IEnumerator Tick()
    {
        while (true)
        {
            Simulate();
            yield return new WaitForSeconds(TickDuration);
        }
    }
}
