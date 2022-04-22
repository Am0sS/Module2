using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DeathAndScoreManager : MonoBehaviour
{

    public GameObject _player;
    public GameObject _gameOverScreen;
    public bool gameOver;
    public float livesLeft;
    public TextMeshProUGUI livesText;

    void Start()
    {
        _gameOverScreen.SetActive(false);
        gameOver = false;
    }

    void Update()
    {
        livesLeft = _player.GetComponent<playerMain>().lives;
        livesText.text = ($"Lives - {livesLeft.ToString()}");

        if (_player.GetComponent<playerMain>().lives == 0) {
            gameOver = true;
            _player.SetActive(false);
            _gameOverScreen.SetActive(true);
            livesText.text = "";
        }

        if (Input.GetKeyDown(KeyCode.F) && gameOver == true) {
            gameOver = false;
            _player.transform.position = new Vector3(0,0,0);
            _player.SetActive(true);
            _gameOverScreen.SetActive(false);
            _player.GetComponent<playerMain>().lives = 3;
            livesText.text = ($"Lives - {livesLeft.ToString()}");
        }
    }
}
