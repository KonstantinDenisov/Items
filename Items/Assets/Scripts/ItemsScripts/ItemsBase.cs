using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ItemsBase : MonoBehaviour
{
    #region Unity Lifecycle

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (!col.gameObject.CompareTag(Tags.Pad))
            return;

        ApplyEffect(col);
        
        Destroy(gameObject);
    }

    #endregion
    
    #region Protected Methods

    protected abstract void ApplyEffect(Collision2D col);

    #endregion
}
