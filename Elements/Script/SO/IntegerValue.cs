using UnityEngine;

namespace BakewareSoftware
{
    [CreateAssetMenu(fileName = "New Integer Value", menuName = "Type Values/Integer")]
    public class IntegerValue : ScriptableObject 
    {
        public int value;

        public static implicit operator int(IntegerValue integerValue) => integerValue.value;

        public static IntegerValue operator -(IntegerValue integerValue, int value) {
            integerValue.value -= value;
            return integerValue;
        }

        public static IntegerValue operator +(IntegerValue integerValue, int value) {
            integerValue.value += value;
            return integerValue;
        }

        public static bool operator >(IntegerValue integerValue, int value) => integerValue.value > value;

        public static bool operator >=(IntegerValue integerValue, int value) => integerValue.value >= value;

        public static bool operator <(IntegerValue integerValue, int value) => integerValue.value < value;

        public static bool operator <=(IntegerValue integerValue, int value) => integerValue.value <= value;
    }
}