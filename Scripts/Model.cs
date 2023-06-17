using System;
using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

public class Model : MonoBehaviour
{
    public float TickDuration;

    public float Balance;

    [SerializeField]
    private float startOilExchangeRate;
    [SerializeField]
    private float startGasExchangeRate;

    [SerializeField]
    private GameObject buildingsList;
    [SerializeField]
    private GameObject cellsList;

    [SerializeField]
    private Building[] buildings;
    [SerializeField]
    private Cell[] cells;


    private void Start()
    {
        Seller.onSell += ChangeBalance;
        Seller.ChangeExchangeRate(startOilExchangeRate, startGasExchangeRate);
        buildings = buildingsList.GetComponentsInChildren<Building>();
        cells = cellsList.GetComponentsInChildren<Cell>();
        foreach (Building building in buildings) 
        { 
            Debug.Log(building.gameObject.name); 
            //building.Cell.Building = building;
        }
        StartCoroutine(Tick());
    }

    private void Simulate() 
    { 
        foreach (var building in buildings) { building.ExecuteOperation(); }
        Seller.ChangeExchangeRate(Seller.OilExchangeRate * Random.Range(0.9f, 1.1f), Seller.GasExchangeRate * Random.Range(0.9f, 1.1f));
        //Money += seller.Sell();
    }

    private void ChangeBalance(float amount)
    {
        Balance += amount;
        Balance = (float)Math.Round(Balance, 2);
    }

    private IEnumerator Tick()
    {
        int step = 0;
        while (true)
        {
            Debug.Log($"-----------{++step}-------------");
            Simulate();
            yield return new WaitForSeconds(TickDuration);
        }
    }
}
