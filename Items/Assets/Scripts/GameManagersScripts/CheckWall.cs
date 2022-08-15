using UnityEngine;

public class CheckWall : MonoBehaviour
{
    #region Unity Lifecycle

    private void OnCollisionEnter2D(Collision2D col)
    {
        ItemsBase item = col.gameObject.GetComponent<ItemsBase>();
        
        if (item.IsGoodItem)
        {
            GameManager.Instance.LoseLife();
            Destroy(col.gameObject);
        }
        else
        {
            Destroy(col.gameObject);
        }
    }

    #endregion
}