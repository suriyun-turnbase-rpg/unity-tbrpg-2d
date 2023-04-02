using UnityEngine;

public class SampleEntityMovement2D : EntityMovement
{
    private void LateUpdate()
    {
        doNotRotate = true;
        switch (HeadDirection2D)
        {
            case EHeadDirection2D.Right:
                transform.eulerAngles = Vector3.up * 0f;
                break;
            case EHeadDirection2D.Left:
                transform.eulerAngles = Vector3.up * 180f;
                break;
        }
    }
}
