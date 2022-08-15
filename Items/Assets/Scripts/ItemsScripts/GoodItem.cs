using UnityEngine;

public class GoodItem : ItemsBase
{
    
    void Start()
    {
        IsGoodItem = true;
    }

    protected override void ApplyEffect(Collision2D col)
    {
        Score = 1;
    }
}
