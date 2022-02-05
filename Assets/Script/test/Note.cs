using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
  // Start is called before the first frame update
  bool isBegin = false;
  float speed = -1;
  float beginTime = 0;
  float globalTime = 0;
  float endTime = 0;
  void Start()
  {
    endTime = Vector3.Distance(this.transform.position, this.transform.parent.position);
    Debug.Log(beginTime);
    Debug.Log(endTime);
  }

  // Update is called once per frame
  void Update()
  {
    globalTime += Time.deltaTime;
    //获取当前物体的中心坐标
    Vector3 nowObj = this.transform.position;
    //获取父物体的坐标
    Vector3 pObj = this.transform.parent.position;
    // Debug.Log(Vector3.Distance(nowObj, pObj));
    if (Input.anyKeyDown)
    {
      if (Math.Abs(globalTime - endTime) < 0.2)
      {
        Debug.Log("OK!");
      }
      else Debug.Log("F");
    }
    this.transform.Translate(new Vector3(0, speed * Time.deltaTime, 0));

  }
}
