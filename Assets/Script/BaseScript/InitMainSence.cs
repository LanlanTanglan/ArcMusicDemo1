using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitMainSence : MonoBehaviour
{
  // Start is called before the first frame update
  void Start()
  {
    //将panel渲染至当前Scenes
    //获取当前Canvas对象
    Canvas canvas = FindObjectOfType<Canvas>();
    // Debug.Log(canvas.name);
    //获取预制体
    GameObject mainPanelPrefab = (GameObject)Resources.Load("UIPrefab/BeginPanel");
    // Debug.Log(mainPanelPrefab.name);
    GameObject mainPanel=Instantiate(mainPanelPrefab);
    mainPanel.transform.position=canvas.transform.position;
    mainPanel.transform.rotation=canvas.transform.rotation;
    mainPanel.transform.localScale=canvas.transform.localScale;
    //将预制体绑定在Canvas上
    mainPanel.transform.SetParent(canvas.transform);
  }

  // Update is called once per frame
  void Update()
  {
    
  }
}
