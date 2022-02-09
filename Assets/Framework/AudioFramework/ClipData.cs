using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//音频加载目录
public class ClipData
{

  public AudioClip audiodata(string name)
  {
    Debug.Log("ClipData:  " + name);
    return Resources.Load<AudioClip>(name);
  }
}