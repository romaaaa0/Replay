using System.Collections.Generic;
using UnityEngine;

namespace Assets
{
    public class Replay : MonoBehaviour
    {
        private List<ObjectCoordinates> _coordinates = new List<ObjectCoordinates>();
        private int _currentIndex;
        private bool _isReplayOn;
        private Rigidbody _rigidbody;
        private IRecord _record;
        private IReplay _replay;
        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
            _record = new ActionRecord(_coordinates);
            _replay = new ActionReplay(_coordinates, transform);
        }
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _isReplayOn = !_isReplayOn;
                if (_isReplayOn)
                {
                    _replay.Replay(0);
                    _rigidbody.isKinematic = true;
                }
                else
                {
                    _replay.Replay(_coordinates.Count - 1);
                    _rigidbody.isKinematic = false;
                }
            }
            if(Input.GetKey(KeyCode.D) && _currentIndex < _coordinates.Count - 1 && _isReplayOn)
            {
                _currentIndex++;
                _replay.Replay(_currentIndex);
            }
            else if(Input.GetKey(KeyCode.A) && _currentIndex > 0 && _isReplayOn)
            {
                _currentIndex--;
                _replay.Replay(_currentIndex);
            }
        }
        private void FixedUpdate()
        {
            if(!_isReplayOn)
                _record.Record(transform.position, transform.rotation);
        }
    }
}
