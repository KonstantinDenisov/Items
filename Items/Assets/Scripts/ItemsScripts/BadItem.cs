using UnityEngine;

public class BadItem : ItemsBase
{
    void Start()
    {
        IsGoodItem = false;
        Score = -1;
    }

    protected override void ApplyEffect(Collision2D col)
    {
        
    }
}