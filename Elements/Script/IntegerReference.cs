namespace BakewareSoftware
{
    [System.Serializable]
    public class IntegerReference 
    {
        public bool useConstant = true;

        public int constantValue;
        public IntegerValue variable;

        public int Value {
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