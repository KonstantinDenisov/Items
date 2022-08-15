using UnityEngine;

public abstract class ItemsBase : MonoBehaviour
{

    #region Variables

    public bool IsGoodItem;
    public int Score;

    #endregion
    
    #region Unity Lifecycle

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (!col.gameObject.CompareTag(Tags.Pad))
            return;

        ApplyEffect(col);
        Statistics.Instance.ChangeScore(Score);
        Destroy(gameObject);
        if (IsGoodItem)
        {
            AudioPlayer.Instance.GoodItemAudioClip();
        }
        else
        {
            AudioPlayer.Instance.BadItemAudioClip();
        }
    }

    #endregion
    
    #region Protected Methods

    protected abstract void ApplyEffect(Collision2D col);

    #endregion
}
