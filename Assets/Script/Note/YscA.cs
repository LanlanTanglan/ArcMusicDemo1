using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YscA : MonoBehaviour
{

  public bool is_tapped = false;
  public bool destroy = false;

  public Animator animator;


  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    if (destroy)
    {
      Debug.Log("删除物体");
      AnimatorStateInfo info = animator.GetCurrentAnimatorStateInfo(0);
      if (info.normalizedTime >= 1.0f)
      {
        Destroy(this.gameObject);
        return;
      }
    }
  }

  public void Tapped()
  {
    Debug.Log("YscA: Tapped!!");
    animator.SetBool("is_tapped", true);
  }

  public void Destroy()
  {
    this.destroy = true;
    Debug.Log("YscA: Destroy!!");
    animator.SetBool("is_dead", true);
    animator.SetBool("is_tapped", false);
  }
}
