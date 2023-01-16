using System;
using UnityEngine;

namespace BakewareSoftware
{
    [CreateAssetMenu(fileName = "New Boolean Value", menuName = "Type Values/Boolean")]
    public class BooleanValue : ScriptableObject 
    {
        public bool value;
        
        public static implicit operator bool(BooleanValue booleanValue) => booleanValue.value;
        protected bool Equals(BooleanValue other) => base.Equals(other) && value == other.value;

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == this.GetType() && Equals((BooleanValue)obj);
        }

        public override int GetHashCode() => HashCode.Combine(base.GetHashCode(), value);
        
        public static bool operator ==(BooleanValue booleanValue, bool value) => booleanValue.value == value;

        public static bool operator !=(BooleanValue booleanValue, bool value) => booleanValue.value != value;
    }
}