using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startKey : MonoBehaviour
{
    public GameObject _bounds;
    public GameObject _player;
    public GameObject _spawner;
    public GameObject _baseUI;
    public GameObject _gameplayUI;
    void Start()
    {
        _bounds.SetActive(false);
        _player.SetActive(false);
        _spawner.SetActive(false);
        _baseUI.SetActive(true);
        _gameplayUI.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
        _bounds.SetActive(true);
        _player.SetActive(true);
        _spawner.SetActive(true);
        _baseUI.SetActive(false);
        _gameplayUI.SetActive(true);
    }
}
}
