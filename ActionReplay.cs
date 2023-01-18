using System.Collections.Generic;
using UnityEngine;

namespace Assets
{
    public class ActionReplay : IReplay
    {
        private List<ObjectCoordinates> _coordinates = new List<ObjectCoordinates>();
        private Transform _transform;
        public ActionReplay(List<ObjectCoordinates> coordinates, Transform transform)
        {
            _coordinates = coordinates;
            _transform = transform;
        }
        public void Replay(int index)
        {
            _transform.position = _coordinates[index].Position;
            _transform.rotation = _coordinates[index].Rotation;
        }
    }
}
