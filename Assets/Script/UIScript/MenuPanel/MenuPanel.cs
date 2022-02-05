using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MenuPanel : MonoBehaviour
{
  //暂时现在这里存储相应的全局变量
  void Start()
  {
    Button[] btns = GetComponentsInChildren<Button>();
    foreach (Button btn in btns)
    {
      setBtnsClick(btn);
    }
  }

  // Update is called once per frame
  void Update()
  {

  }

  public void setBtnsClick(Button btn)
  {
    switch (btn.name)
    {
      case "Music1":
        btn.onClick.AddListener(delegate ()
        {
          //隐藏当前Panel
          //载入音乐脚本
          //根据脚本载入对应的物体进入游戏场景
          //或者
          /*
              将铺面的名称放入一个gameObject
              然后另一个专门读取铺面的脚本用于载入预制体
              这样子可以压缩代码

              读取脚本
              当然首要的就是读取某个音乐文件然后播放
              如下我用一个函数来按序测试基本功能
          */
          //如下此地方用于测试预制体的载入问题
          CanvasGroup cg = this.transform.GetComponent<CanvasGroup>();
          cg.alpha = 0;
          cg.interactable = false;
          cg.blocksRaycasts = false;
          Music1();
        });
        break;
      case "Music2":
        btn.onClick.AddListener(delegate ()
        {

        });
        break;
    }
  }



  private void Music1()
  {
    //通过音乐播放器播放音乐
    /*
      在不同的铺面过程中，播放音乐是需要一定的延时才行
      那么全局计时器是大致从负数开始执行的
    */
    AudioManager.Instance.AudioPlay("Speed_of_Light");

  }

  private void Staff1()
  {
    /*
      执行该铺面
      第一步，读取铺面json文件
      第二部，生成铺面的obj（有两种方式，1 全部生成在Scene上, 2 按照时间顺序逐步生成防止内存泄露
    */

  }
}
