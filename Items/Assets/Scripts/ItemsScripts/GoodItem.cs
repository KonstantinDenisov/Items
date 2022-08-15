using UnityEngine;

public class GoodItem : ItemsBase
{
    
    void Start()
    {
        IsGoodItem = true;
        Score = 1;
    }

    protected override void ApplyEffect(Collision2D col)
    {
        
    }
}
