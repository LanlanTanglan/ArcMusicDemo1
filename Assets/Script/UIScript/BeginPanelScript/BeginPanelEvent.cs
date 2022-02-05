using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BeginPanelEvent : MonoBehaviour
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
      case "GameStartBtn":
        btn.onClick.AddListener(delegate ()
        {
          Debug.Log("开始选择歌曲");
          //使用CanvasGroup隐藏当前Panel-->BeginPanel
          CanvasGroup cg = this.transform.GetComponent<CanvasGroup>();
          cg.alpha = 0;
          cg.interactable = false;
          cg.blocksRaycasts = false;
          //开启菜单面板
          GameObject menuPanel = (GameObject)Resources.Load("UIPrefab/MenuPanel");
          GameObject menuPanelObj = Instantiate(menuPanel);
          Canvas canvas = FindObjectOfType<Canvas>();
          menuPanelObj.transform.position = canvas.transform.position;
          menuPanelObj.transform.rotation = canvas.transform.rotation;
          menuPanelObj.transform.localScale = canvas.transform.localScale;
          //将预制体绑定在Canvas上
          menuPanelObj.transform.SetParent(canvas.transform);
        });
        break;
    }
  }
}
