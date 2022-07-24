namespace SandBox.Modern
{
    public static class DeStringify
    {
        static public int GetIntSafely(string theInt) {
            int _int = 0;
            int.TryParse(theInt, out _int);
            return _int;
        }

        static public double GetDblSafely(string theDbl)
        {
            double _double = 0;
            double.TryParse(theDbl, out _double);
            return _double;
        }

        static public bool GetBoolSafely(string theBool) {
            bool _bool = false;
            bool.TryParse(theBool, out _bool);
            return _bool;
        }
    }
}
