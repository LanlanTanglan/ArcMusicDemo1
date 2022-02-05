using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainPanelEvent : MonoBehaviour
{
  // Start is called before the first frame update
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
      case "GotoAnotherPanelBtn":
        btn.onClick.AddListener(delegate ()
        {
          Debug.Log("切换控制面板");
        });
        break;
      case "ExitBtn":
        btn.onClick.AddListener(delegate ()
        {

          Debug.Log("退出该面板");
        });
        break;
    }
  }
}
