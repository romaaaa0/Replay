using System.Collections.Generic;
using UnityEngine;

namespace Assets
{
    public class ActionRecord : IRecord
    {
        private List<ObjectCoordinates> _coordinates = new List<ObjectCoordinates>();
        public ActionRecord(List<ObjectCoordinates> coordinates)
        {
            _coordinates = coordinates;
        }
        public void Record(Vector3 position, Quaternion rotation)
        {
            _coordinates.Add(new ObjectCoordinates()
            {
                Position = position,
                Rotation = rotation
            });
        }
    }
}
