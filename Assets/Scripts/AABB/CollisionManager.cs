using UnityEngine;

public class CollisionManager : MonoBehaviour
{
    public Shape MainCharacter;
    private Shape[] colliders;

    private void Start()
    {
        colliders = FindObjectsOfType<Shape>();
    }

    private void Update()
    {
        DetectCollision();
    }

    private void DetectCollision()
    {
        foreach (var collider in colliders)
        {
            if (collider.CompareTag("Player")) continue;

            if (CheckCollision(collider, MainCharacter))
            {
                MainCharacter.GetComponent<PlayerController>().gravityEnabled = false;
                Debug.LogError("Collision Detected");
            }
        }
    }

    private bool CheckCollision(Shape shapeA, Shape shapeB)
    {
        if(shapeA is BoxCollision && shapeB is BoxCollision)
        {
            var boxA = (BoxCollision)shapeA;
            var boxB = (BoxCollision)shapeB;
            return CollisionLibrary.DidCollide(boxA, boxB);
        }

        return false;
    }

    private void OnDrawGizmos()
    {
        var Colliders = FindObjectsOfType<Shape>();
        foreach (var c in Colliders)
        {
            c.DrawCollider();
        }
    }
}
