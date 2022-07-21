using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SortingOrderScript : MonoBehaviour
{
  public const string LAYER_NAME = "Top";
  public int sortingOrder = 1;
  private SpriteRenderer sprite;

  void Start()
  {
    sprite = GetComponent<SpriteRenderer>();

    if (sprite)
      sprite.sortingOrder = sortingOrder;
      sprite.sortingLayerName = LAYER_NAME;

  }

  void Update()
  {

  }

}
