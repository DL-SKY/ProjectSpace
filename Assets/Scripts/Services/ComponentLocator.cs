using System;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectSpace.Services
{
    public static class ComponentLocator
    {
        public static Action<Type> OnRegister;

        private static readonly Dictionary<Type, Component> components = new Dictionary<Type, Component>();


        public static void Register<T>(T _component) where T : Component
        {
            var type = _component.GetType();
            if (components.ContainsKey(type))
                components[type] = _component;
            else
                components.Add(type, _component);

            OnRegister?.Invoke(type);

            Debug.LogWarning("[ComponentLocator] Register " + type.ToString());
        }

        public static void Unregister<T>() where T : Component
        {
            var type = typeof(T);
            Unregister(type);
        }

        public static void Unregister(Type _type)
        {
            components.Remove(_type);

            Debug.LogWarning("[ComponentLocator] Unregister " + _type.ToString());
        }

        public static T Resolve<T>() where T : Component
        {
            var type = typeof(T);

            if (components.ContainsKey(type))
                return (T)components[type];

            return default;
        }

        public static void Clear()
        {
            components.Clear();
        }
    }
}
