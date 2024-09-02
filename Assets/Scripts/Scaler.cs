using UnityEngine;

public class Scaler : TransformChanger
{
    protected override void PerformUpdate(Transform transform, float speed)
    {
        transform.localScale += speed * Time.deltaTime * transform.localScale;
    }
}
