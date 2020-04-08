﻿using UnityEngine;
using UnityEngine.AI;

public interface IPlayerState 
{
    void Init(PlayerData playerData, Camera camera, CharacterController playerController = null, Animator animator = null);
    void Enter(Collider collider = null);
    void Update();
    void Exit();
}
