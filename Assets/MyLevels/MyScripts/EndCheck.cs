using System.Collections;
using System.Collections.Generic;
using MoreMountains.CorgiEngine;
using MoreMountains.Tools;
using UnityEngine;

public class EndCheck : FinishLevel
{
    [MMInspectorGroup("Stars", true, 30)]
    [SerializeField] private GameObject retroAdScene;
    protected override void OnTriggerEnter2D(Collider2D other)
    {
        if (retroAdScene.GetComponent<RetroAdventureProgressManager>().CurrentStars == 3)
        {
            base.OnTriggerEnter2D(other);
        }
    }
}
