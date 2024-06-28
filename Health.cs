using UnityEngine;
using System;

public class Health : MonoBehaviour
{
    [SerializeField] private int _maxValue;
    [SerializeField] private int _�urrentValue;

    public float CurrentValue => _�urrentValue;
    public float MaxValue => _maxValue;
    public event Action HealthChanged;

    public void Start()
    {
        _�urrentValue = _maxValue;
        HealthChanged?.Invoke();
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Decrease(1);
        }

        if (Input.GetMouseButtonDown(1))
        {
            Increase(1);
        }
    }

    public void Decrease(int value)
    {
        if (value < 0)
        {
            return;
        }

        _�urrentValue -= value;
        
        if (CurrentValue < 0)
        {
            _�urrentValue = 0;
        }

        HealthChanged?.Invoke();
    }

    public void Increase(int value)
    {
        if (value < 0)
        {
            return;
        }

        _�urrentValue += value;

        if (CurrentValue > _maxValue)
        {
            _�urrentValue = _maxValue;
        }

        HealthChanged?.Invoke();
    }
}
