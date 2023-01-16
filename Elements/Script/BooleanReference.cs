namespace BakewareSoftware
{
    [System.Serializable]
    public class BooleanReference 
    {
        public bool useConstant = true;

        public bool constantValue;
        public BooleanValue variable;

        public bool Value {
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