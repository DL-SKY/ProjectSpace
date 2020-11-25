using ProjectSpace.Interfaces.Ships;
using ProjectSpace.ScriptableObjects.Ships;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectSpace.Object.Ships
{
    public class SpaceshipController : MonoBehaviour, ISpaceship
    {
        [Header("Settings")]
        [SerializeField] private SpaceshipConfig config;
    }
}
