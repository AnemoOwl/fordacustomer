using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipFlopY : MonoBehaviour
{
    public SpriteRenderer FloppY;
    
    public void FlopMe()
    {
        FloppY.flipY = !FloppY.flipY;
    }

}
