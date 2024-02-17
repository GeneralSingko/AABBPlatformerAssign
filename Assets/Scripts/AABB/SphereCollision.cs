using UnityEngine;

public class SphereCollision : Shape
{
    public float Length;
    public float Width;

    public void InitSphere(float length, float width, Vector2 origin)
    {
        Length = length;
        Width = width;
        origin = this.originPoint;
    }

    public override void DrawCollider()
    {
        base.DrawCollider();
    }
}
