using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOperator : MonoBehaviour
{
    private Transform root;

    private void Awake()
    {
        root = transform.Find("Root");
    }

    private void Start()
    {
        GameManager.Instance.OnGameStateChange += OnGameStateChange;
    }

    private void OnGameStateChange(GameState gameState)
    {
        if(gameState == GameState.countDown)
        Show();
    }

    private void Show()
    {
        root.gameObject.SetActive(true);
    }
}
