using System;
using Core;
using UnityEngine;
using UnityEngine.UI;

public class ResourceVisual : MonoBehaviour
{
    [SerializeField] private GameResource currentGameResource;

    private ObservableInt _currentCounter;
    private Text _gameResourceAmountText;

    private void Awake()
    {
        _gameResourceAmountText = GetComponent<Text>();
    }

    private void Start()
    {
        _currentCounter = ResourceBank.GetResource(currentGameResource);
        _gameResourceAmountText.text = _currentCounter.Value.ToString();
        _currentCounter.OnValueChanged =
                    value => _gameResourceAmountText.text = value.ToString();
    }
}