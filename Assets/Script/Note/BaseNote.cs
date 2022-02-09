using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Model;

public class BaseNote : MonoBehaviour
{
  public bool is_tapped = false;
  public bool is_moving = false;
  public bool is_inited = false;
  public NoteModel noteModel;

  public UnityEvent Tapped;
  public UnityEvent Destory;

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    //可以刷新
    if (is_inited)
    {
      //事件监听
      if (Input.anyKey)
      {
        Debug.Log("已点击");
        //判断是否在正确点击的范围内
        if (Math.Abs(GameClockManager.Instance.game_time - noteModel.end_time) <= 0.1)
        {
          //执行点击动画
          Tapped.Invoke();
          Debug.Log("BaseNote 点击成功");
          //延后一段时间_销毁该物体，由动画自身调用
          Destroy(this.gameObject, 0.417f);//此方法不是正确的物体销毁方式
          //计数
        }
      }
      //位置刷新（目前默认是向下的）
      this.transform.Translate(new Vector3(0, noteModel.speed / 100 * Time.deltaTime, 0));
    }
  }
  public void initBaseNote(NoteModel noteModel)
  {
    this.noteModel = noteModel;
    this.is_inited = true;
  }
}
