﻿using UnityEngine.SceneManagement;
using UnityEngine;
public class GameState : IGameState
{
    public void Enter()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void Exit()
    {
        SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());
    }
}