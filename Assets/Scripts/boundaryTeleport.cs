using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boundaryTeleport : MonoBehaviour
{
    public GameObject _player;
    public GameObject _bullet;
    public float currentX;
    public float currentY;
    public float negativeX;
    public float negativeY;

    public float addedValue; 

    void Start()
    {
    }

    void Update()
    {
       // Debug.Log($"X: {currentX} Y: {currentY}");
        currentX = _player.transform.position.x;
        currentY = _player.transform.position.y;
        negativeX = -currentX;
        negativeY = -currentY;
    }

    void OnTriggerEnter2D(Collider2D other) {
      if (other.gameObject.CompareTag("Player"))
        {
            _player.transform.position = new Vector2(negativeX + addedValue, negativeY + addedValue);

        }
    }
        

}
