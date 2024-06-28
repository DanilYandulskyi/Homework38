using UnityEngine;

public abstract class HealthUI : MonoBehaviour
{
    [SerializeField] private Health _health;

    protected Health Health => _health;

    private void Awake()
    {
        _health.HealthChanged += UpdateUI;
    }

    private void OnDestroy()
    {
        _health.HealthChanged -= UpdateUI;
    }

    protected abstract void UpdateUI();
}