using System.Drawing;
using UnityEngine;

public class Pad : MonoBehaviour
{
    #region Variables

    public bool IsPadCatcher;

    [SerializeField] private Vector3 _minScale = Vector3.one;
    [SerializeField] private Vector3 _maxScale;

    #endregion


    #region Unity Lifecycle

    private void Update()
    {
        if (PauseManager.Instance.IsPaused)
            return;
        
        else
        {
            Vector3 mousePositionInPixels = Input.mousePosition;
            Vector3 mousePositionInUnits = Camera.main.ScreenToWorldPoint(mousePositionInPixels);
            Vector3 currentPosition = transform.position;
            currentPosition.x = mousePositionInUnits.x;
            transform.position = currentPosition; 
        }
    }
    #endregion


    #region Public Methods

    public void ChangeScale(float multiplier)
    {
        Vector3 currentScale = transform.localScale;
        currentScale *= multiplier;

        if (currentScale.magnitude > _maxScale.magnitude)
        {
            currentScale = _maxScale;
        }

        if (currentScale.magnitude < _minScale.magnitude)
        {
            currentScale = _minScale;
        }

        transform.localScale = currentScale;
    }

    #endregion
}