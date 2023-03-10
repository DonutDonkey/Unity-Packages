using UnityEngine;

namespace BakewareSoftware
{
    [CreateAssetMenu(fileName = "New Float Value", menuName = "Type Values/Float")]
    public class FloatValue : ScriptableObject 
    {
        public float value;

        public static implicit operator float(FloatValue floatValue) => floatValue.value;

        public static FloatValue operator -(FloatValue floatValue, float value) {
            floatValue.value -= value;
            return floatValue;
        }

        public static FloatValue operator +(FloatValue floatValue, float value) {
            floatValue.value += value;
            return floatValue;
        }

        public static bool operator >(FloatValue floatValue, float value) => floatValue.value > value;

        public static bool operator >=(FloatValue floatValue, float value) => floatValue.value >= value;

        public static bool operator <(FloatValue floatValue, float value) => floatValue.value < value;

        public static bool operator <=(FloatValue floatValue, float value) => floatValue.value <= value;
    }
}