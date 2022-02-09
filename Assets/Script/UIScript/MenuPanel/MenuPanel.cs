using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Model;
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
          Staff1();
          //启动游戏计时器
          GameClockManager.Instance.refresh();
          GameClockManager.Instance.is_start_game = true;
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
    AudioManager.Instance.AudioDelayPlay("Music/Speed_of_Light", 5f);

  }

  private void Staff1()
  {
    /*
      执行该铺面
      第一步，读取铺面json文件
      第二部，生成铺面的obj（有两种方式，1 全部生成在Scene上, 2 按照时间顺序逐步生成防止内存泄露
    */

    //测试部分
    Application.targetFrameRate = 60;
    //生成一个Note数据
    NoteModel note1 = new NoteModel(-5, 0.3328f, new Vector3(-300 / 100, 1599.84f / 100, 0), new Vector3(-300, 0, 0));
    NoteModel note2 = new NoteModel(-5, 0.8757f, new Vector3(300 / 100, 1762.71f / 100, 0), new Vector3(300, 0, 0));
    NoteModel note3 = new NoteModel(-5, 1.1232f, new Vector3(-300 / 100, 1836.96f / 100, 0), new Vector3(-300, 0, 0));
    NoteModel note4 = new NoteModel(-5, 1.7056f, new Vector3(300 / 100, 2011.68f / 100, 0), new Vector3(300, 0, 0));
    NoteModel note5 = new NoteModel(-5, 2.2048f, new Vector3(-300 / 100, 2161.44f / 100, 0), new Vector3(-300, 0, 0));
    NoteModel note6 = new NoteModel(-5, 2.7456f, new Vector3(300 / 100, 2323.68f / 100, 0), new Vector3(300, 0, 0));
    NoteModel note7 = new NoteModel(-5, 3.2864f, new Vector3(-300 / 100, 2485.92f / 100, 0), new Vector3(-300, 0, 0));
    NoteModel note8 = new NoteModel(-5, 3.8272f, new Vector3(300 / 100, 2648.16f / 100, 0), new Vector3(300, 0, 0));
    NoteModel note9 = new NoteModel(-5, 4.3264f, new Vector3(-300 / 100, 2797.92f / 100, 0), new Vector3(-300, 0, 0));
    NoteModel note10 = new NoteModel(-5, 4.6592f, new Vector3(300 / 100, 2897.76f / 100, 0), new Vector3(300, 0, 0));

    //生成一个Note预制体，并初始化其基本信息
    initNote(note1);
    initNote(note2);
    initNote(note3);
    initNote(note4);
    initNote(note5);
    initNote(note6);
    initNote(note7);
    initNote(note8);
    initNote(note9);
    initNote(note10);
  }

  public void initNote(NoteModel n)
  {
    GameObject y = Instantiate((GameObject)Resources.Load("NotePrefab/Ysc_a"));
    y.transform.position = n.begin_pos;
    y.GetComponent<BaseNote>().initBaseNote(n);
  }
}
