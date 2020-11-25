using ProjectSpace.Interfaces.Ships;
using ProjectSpace.ScriptableObjects.Ships;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectSpace.Object.Ships
{
    public class SpaceshipController : MonoBehaviour, ISpaceship
    {
        [Header("Settings")]
        [SerializeField] private SpaceshipConfig config;
        [SerializeField] private Transform subsystemsHolder;
        [SerializeField] private Transform spaceshipBow;

        public List<ISpaceshipSubsystem> Subsystems { get; private set; }
        public Transform SpaceshipTransform => transform;
        public Transform SpaceshipBow => spaceshipBow;


        private void Awake()
        {
            Subsystems = new List<ISpaceshipSubsystem>();

            var subssys = subsystemsHolder.GetComponents<ISpaceshipSubsystem>();
            foreach (var subsys in subssys)
            {
                subsys.Initialize(this);
                Subsystems.Add(subsys);
            }
        }
    }
}
