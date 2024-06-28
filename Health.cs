using UnityEngine;
using System;

public class Health : MonoBehaviour
{
    [SerializeField] private int _maxValue;
    [SerializeField] private int _ñurrentValue;

    public float CurrentValue => _ñurrentValue;
    public float MaxValue => _maxValue;
    public event Action HealthChanged;

    public void Start()
    {
        _ñurrentValue = _maxValue;
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

        _ñurrentValue -= value;
        
        if (CurrentValue < 0)
        {
            _ñurrentValue = 0;
        }

        HealthChanged?.Invoke();
    }

    public void Increase(int value)
    {
        if (value < 0)
        {
            return;
        }

        _ñurrentValue += value;

        if (CurrentValue > _maxValue)
        {
            _ñurrentValue = _maxValue;
        }

        HealthChanged?.Invoke();
    }
}
