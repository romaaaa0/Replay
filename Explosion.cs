using UnityEngine;

namespace Assets
{
    public class Explosion : MonoBehaviour
    {
        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.W)) 
                Explode();
        }
        private void Explode()
        {
            var radius = 10;
            var explosionForce = 800f;
            var collectionColliders = CollectionColliders(radius);
            for (int i = 0; i < collectionColliders.Length; i++)
            {
                var rigidbody = collectionColliders[i].attachedRigidbody;
                if (rigidbody)
                    rigidbody.AddExplosionForce(explosionForce, transform.position, radius);
            }
        }
        private Collider[] CollectionColliders(int radius)
        {
            return Physics.OverlapSphere(transform.position, radius);
        }
    }
}
