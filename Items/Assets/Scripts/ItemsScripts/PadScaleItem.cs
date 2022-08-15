using UnityEngine;

public class PadScaleItem : ItemsBase
{

    #region Variables

    [SerializeField] private float _multiplier;

    #endregion


    #region Unity Lifecycle

    void Start()
    {
        IsGoodItem = true;
        Score = 1;
    }

    #endregion
        
    protected override void ApplyEffect(Collision2D col)
    {
        FindObjectOfType<Pad>().ChangeScale(_multiplier);
    }
        
}