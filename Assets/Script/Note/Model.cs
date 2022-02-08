using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Model
{
  public class NoteModel
  {
    public float speed;
    public float begin_time;
    public float end_time;
    public Vector3 begin_pos;
    public Vector3 end_pos;
    public string note_type = "default";


    public NoteModel(float begin_time, float end_time, Vector3 begin_pos, Vector3 end_pos)
    {
      this.begin_time = begin_time;
      this.end_time = end_time;
      this.begin_pos = begin_pos;
      this.end_pos = end_pos;
      this.speed = -10;
    }
  }
}