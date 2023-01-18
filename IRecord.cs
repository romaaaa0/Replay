using System.Collections.Generic;
using UnityEngine;

namespace Assets
{
    public interface IRecord
    {
        void Record(Vector3 position, Quaternion rotation);
    }
}
