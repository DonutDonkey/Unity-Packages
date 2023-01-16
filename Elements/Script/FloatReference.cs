using UnityEngine.Serialization;

namespace BakewareSoftware
{
    [System.Serializable]
    public class FloatReference 
    {
        public bool useConstant = true;

        public float constantValue;
        public FloatValue variable;

        public float Value {
            get => useConstant ? constantValue : variable.value;
            set {
                if (useConstant) 
                    constantValue = value;
                else 
                    variable.value = value;
            }
        }
    }
}