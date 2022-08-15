using UnityEngine;

public class BadItem : ItemsBase
{
    void Start()
    {
        IsGoodItem = false;
    }

    protected override void ApplyEffect(Collision2D col)
    {
        Score = -1;
    }
}