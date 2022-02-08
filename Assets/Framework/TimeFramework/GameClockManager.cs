using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameClockManager : MonoBehaviour
{

  public static GameClockManager Instance;
  public bool is_start_game = false;//游戏是否开始
  public float game_time = 0;//游戏游玩时间

  void Awake()
  {
    Instance = this;
  }

  void Start()
  {
    
  }

  void Update()
  {
    if (is_start_game)
    {
      game_time += Time.deltaTime;
    }
  }

  public void refresh()
  {
    is_start_game = false;
    game_time = 0;
  }
}