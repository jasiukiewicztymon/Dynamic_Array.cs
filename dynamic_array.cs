using System;

namespace DynamicArray
{
    class dynamicarray
    {
        private string type = "";
        private int size = 1, newsize = 0;

        /*
        All possible format tables 
        */
        private int[] IntArr; private float[] FloatArr; private double[] DoubleArr; private byte[] ByteArr; private sbyte[] SByteArr; private uint[] UIntArr; private short[] ShortArr; private ushort[] UShortArr; private long[] LongArr; private ulong[] ULongArr; private char[] CharArr; private bool[] BoolArr; private object[] ObjectArr; private string[] StringArr; private decimal[] DecimalArr;
        private dynamicarray[] dynamicarrayArr; private dynamic[] DynamicArr;

        private int[] TempIntArr; private float[] TempFloatArr; private double[] TempDoubleArr; private byte[] TempByteArr; private sbyte[] TempSByteArr; private uint[] TempUIntArr; private short[] TempShortArr; private ushort[] TempUShortArr; private long[] TempLongArr; private ulong[] TempULongArr; private char[] TempCharArr; private bool[] TempBoolArr; private object[] TempObjectArr; private string[] TempStringArr; private decimal[] TempDecimalArr;
        private dynamicarray[] TempdynamicarrayArr; private dynamic[] TempDynamicArr;
        /*
        Default constructor for a definied data type but unknow size 
        */
        public dynamicarray(string inputtype)
        {
            switch (inputtype)
            {
                case "int":
                    this.IntArr = new int[0]; type = "int"; size = 0;
                    break;
                case "float":
                    this.FloatArr = new float[0]; type = "float"; size = 0;
                    break;
                case "double":
                    this.DoubleArr = new double[0]; type = "double"; size = 0;
                    break;
                case "byte":
                    this.ByteArr = new byte[0]; type = "byte"; size = 0;
                    break;
                case "sbyte":
                    this.SByteArr = new sbyte[0]; type = "sbyte"; size = 0;
                    break;
                case "uint":
                    this.UIntArr = new uint[0]; type = "uint"; size = 0;
                    break;
                case "short":
                    this.ShortArr = new short[0]; type = "short"; size = 0;
                    break;
                case "ushort":
                    this.UShortArr = new ushort[0]; type = "ushort"; size = 0;
                    break;
                case "long":
                    this.LongArr = new long[0]; type = "long"; size = 0;
                    break;
                case "ulong":
                    this.ULongArr = new ulong[0]; type = "ulong"; size = 0;
                    break;
                case "char":
                    this.CharArr = new char[0]; type = "char"; size = 0;
                    break;
                case "bool":
                    this.BoolArr = new bool[0]; type = "bool"; size = 0;
                    break;
                case "object":
                    this.ObjectArr = new object[0]; type = "object"; size = 0;
                    break;
                case "string":
                    this.StringArr = new string[0]; type = "string"; size = 0;
                    break;
                case "decimal":
                    this.DecimalArr = new decimal[0]; type = "decimal"; size = 0;
                    break;
                case "dynamic":
                    this.DynamicArr = new dynamic[0]; type = "dynamic"; size = 0;
                    break;
                case "dynamicarray":
                    this.dynamicarrayArr = new dynamicarray[0]; type = "dynamicarray"; size = 0;
                    break;
                default: throw new Exception("Invalide data type!");
            }
        }
        /*
        Default constructor for definied data type and size 
        */
        public dynamicarray(string inputtype, int inputsize)
        {
            switch (inputtype)
            {
                case "int":
                    this.IntArr = new int[inputsize]; type = "int"; size = IntArr.Length;
                    break;
                case "float":
                    this.FloatArr = new float[inputsize]; type = "float"; size = FloatArr.Length;
                    break;
                case "double":
                    this.DoubleArr = new double[inputsize]; type = "double"; size = DoubleArr.Length;
                    break;
                case "byte":
                    this.ByteArr = new byte[inputsize]; type = "byte"; size = ByteArr.Length;
                    break;
                case "sbyte":
                    this.SByteArr = new sbyte[inputsize]; type = "sbyte"; size = SByteArr.Length;
                    break;
                case "uint":
                    this.UIntArr = new uint[inputsize]; type = "uint"; size = UIntArr.Length;
                    break;
                case "short":
                    this.ShortArr = new short[inputsize]; type = "short"; size = ShortArr.Length;
                    break;
                case "ushort":
                    this.UShortArr = new ushort[inputsize]; type = "ushort"; size = UShortArr.Length;
                    break;
                case "long":
                    this.LongArr = new long[inputsize]; type = "long"; size = LongArr.Length;
                    break;
                case "ulong":
                    this.ULongArr = new ulong[inputsize]; type = "ulong"; size = ULongArr.Length;
                    break;
                case "char":
                    this.CharArr = new char[inputsize]; type = "char"; size = CharArr.Length;
                    break;
                case "bool":
                    this.BoolArr = new bool[inputsize]; type = "bool"; size = BoolArr.Length;
                    break;
                case "object":
                    this.ObjectArr = new object[inputsize]; type = "object"; size = ObjectArr.Length;
                    break;
                case "string":
                    this.StringArr = new string[inputsize]; type = "string"; size = StringArr.Length;
                    break;
                case "decimal":
                    this.DecimalArr = new decimal[inputsize]; type = "decimal"; size = DecimalArr.Length;
                    break;
                case "dynamic":
                    this.DynamicArr = new dynamic[inputsize]; type = "dynamic"; size = DynamicArr.Length;
                    break;
                case "dynamicarray":
                    this.dynamicarrayArr = new dynamicarray[inputsize]; type = "dynamicarray"; size = dynamicarrayArr.Length;
                    break;
                default: throw new Exception("Invalide data type!");
            }
        }
        /*
        dynamicarray.push_front(value) add value on front 
        dynamicarray.push_back(value) add value on back
        */
        public void push_front(dynamic value)
        {
            try
            {
                switch (type)
                {
                    case "int":
                        this.TempIntArr = new int[size];
                        for (int i = 0; i < size; i++)
                        {
                            TempIntArr[i] = IntArr[i];
                        }
                        size += 1;
                        this.IntArr = new int[size];
                        IntArr[0] = value;

                        for (int i = 1; i < size; i++)
                        {
                            IntArr[i] = TempIntArr[i - 1];
                        }
                        break;
                    case "float":
                        this.TempFloatArr = new float[size];
                        for (int i = 0; i < size; i++)
                        {
                            TempFloatArr[i] = FloatArr[i];
                        }
                        size += 1;
                        this.FloatArr = new float[size];
                        FloatArr[0] = value;

                        for (int i = 1; i < size; i++)
                        {
                            FloatArr[i] = TempFloatArr[i - 1];
                        }
                        break;
                    case "double":
                        this.TempDoubleArr = new double[size];
                        for (int i = 0; i < size; i++)
                        {
                            TempDoubleArr[i] = DoubleArr[i];
                        }
                        size += 1;
                        this.DoubleArr = new double[size];
                        DoubleArr[0] = value;

                        for (int i = 1; i < size; i++)
                        {
                            DoubleArr[i] = TempDoubleArr[i - 1];
                        }
                        break;
                    case "byte":
                        this.TempByteArr = new byte[size];
                        for (int i = 0; i < size; i++)
                        {
                            TempByteArr[i] = ByteArr[i];
                        }
                        size += 1;
                        this.ByteArr = new byte[size];
                        ByteArr[0] = value;

                        for (int i = 1; i < size; i++)
                        {
                            ByteArr[i] = TempByteArr[i - 1];
                        }
                        break;
                    case "sbyte":
                        this.TempSByteArr = new sbyte[size];
                        for (int i = 0; i < size; i++)
                        {
                            TempSByteArr[i] = SByteArr[i];
                        }
                        size += 1;
                        this.SByteArr = new sbyte[size];
                        SByteArr[0] = value;

                        for (int i = 1; i < size; i++)
                        {
                            SByteArr[i] = TempSByteArr[i - 1];
                        }
                        break;
                    case "uint":
                        this.TempUIntArr = new uint[size];
                        for (int i = 0; i < size; i++)
                        {
                            TempUIntArr[i] = UIntArr[i];
                        }
                        size += 1;
                        this.UIntArr = new uint[size];
                        UIntArr[0] = value;

                        for (int i = 1; i < size; i++)
                        {
                            UIntArr[i] = TempUIntArr[i - 1];
                        }
                        break;
                    case "short":
                        this.TempShortArr = new short[size];
                        for (int i = 0; i < size; i++)
                        {
                            TempShortArr[i] = ShortArr[i];
                        }
                        size += 1;
                        this.ShortArr = new short[size];
                        ShortArr[0] = value;

                        for (int i = 1; i < size; i++)
                        {
                            ShortArr[i] = TempShortArr[i - 1];
                        }
                        break;
                    case "ushort":
                        this.TempUShortArr = new ushort[size];
                        for (int i = 0; i < size; i++)
                        {
                            TempUShortArr[i] = UShortArr[i];
                        }
                        size += 1;
                        this.UShortArr = new ushort[size];
                        UShortArr[0] = value;

                        for (int i = 1; i < size; i++)
                        {
                            UShortArr[i] = TempUShortArr[i - 1];
                        }
                        break;
                    case "long":
                        this.TempLongArr = new long[size];
                        for (int i = 0; i < size; i++)
                        {
                            TempLongArr[i] = LongArr[i];
                        }
                        size += 1;
                        this.LongArr = new long[size];
                        LongArr[0] = value;

                        for (int i = 1; i < size; i++)
                        {
                            LongArr[i] = TempLongArr[i - 1];
                        }
                        break;
                    case "ulong":
                        this.TempULongArr = new ulong[size];
                        for (int i = 0; i < size; i++)
                        {
                            TempULongArr[i] = ULongArr[i];
                        }
                        size += 1;
                        this.ULongArr = new ulong[size];
                        ULongArr[0] = value;

                        for (int i = 1; i < size; i++)
                        {
                            ULongArr[i] = TempULongArr[i - 1];
                        }
                        break;
                    case "char":
                        this.TempCharArr = new char[size];
                        for (int i = 0; i < size; i++)
                        {
                            TempCharArr[i] = CharArr[i];
                        }
                        size += 1;
                        this.CharArr = new char[size];
                        CharArr[0] = value;

                        for (int i = 1; i < size; i++)
                        {
                            CharArr[i] = TempCharArr[i - 1];
                        }
                        break;
                    case "bool":
                        this.TempBoolArr = new bool[size];
                        for (int i = 0; i < size; i++)
                        {
                            TempBoolArr[i] = BoolArr[i];
                        }
                        size += 1;
                        this.BoolArr = new bool[size];
                        BoolArr[0] = value;

                        for (int i = 1; i < size; i++)
                        {
                            BoolArr[i] = TempBoolArr[i - 1];
                        }
                        break;
                    case "object":
                        this.TempObjectArr = new object[size];
                        for (int i = 0; i < size; i++)
                        {
                            TempObjectArr[i] = ObjectArr[i];
                        }
                        size += 1;
                        this.ObjectArr = new object[size];
                        ObjectArr[0] = value;

                        for (int i = 1; i < size; i++)
                        {
                            ObjectArr[i] = TempObjectArr[i - 1];
                        }
                        break;
                    case "string":
                        this.TempStringArr = new string[size];
                        for (int i = 0; i < size; i++)
                        {
                            TempStringArr[i] = StringArr[i];
                        }
                        size += 1;
                        this.StringArr = new string[size];
                        StringArr[0] = value;

                        for (int i = 1; i < size; i++)
                        {
                            StringArr[i] = TempStringArr[i - 1];
                        }
                        break;
                    case "decimal":
                        this.TempDecimalArr = new decimal[size];
                        for (int i = 0; i < size; i++)
                        {
                            TempDecimalArr[i] = DecimalArr[i];
                        }
                        size += 1;
                        this.DecimalArr = new decimal[size];
                        DecimalArr[0] = value;

                        for (int i = 1; i < size; i++)
                        {
                            DecimalArr[i] = TempDecimalArr[i - 1];
                        }
                        break;
                    case "dynamic":
                        this.TempDynamicArr = new dynamic[size];
                        for (int i = 0; i < size; i++)
                        {
                            TempDynamicArr[i] = DynamicArr[i];
                        }
                        size += 1;
                        this.DynamicArr = new dynamic[size];
                        DynamicArr[0] = value;

                        for (int i = 1; i < size; i++)
                        {
                            DynamicArr[i] = TempDynamicArr[i - 1];
                        }
                        break;
                    case "dynamicarray":
                        this.TempdynamicarrayArr = new dynamicarray[size];
                        for (int i = 0; i < size; i++)
                        {
                            TempdynamicarrayArr[i] = dynamicarrayArr[i];
                        }
                        size += 1;
                        this.dynamicarrayArr = new dynamicarray[size];
                        dynamicarrayArr[0] = value;

                        for (int i = 1; i < size; i++)
                        {
                            dynamicarrayArr[i] = TempdynamicarrayArr[i - 1];
                        }
                        break;
                }
            }
            catch
            {
                throw new Exception("Invalide type of appeneded element!");
            }
        }

        public void push_back(dynamic value)
        {
            try
            {
                switch (type)
                {
                    case "int":
                        this.TempIntArr = new int[size];
                        for (int i = 0; i < size; i++)
                        {
                            TempIntArr[i] = IntArr[i];
                        }
                        size += 1;
                        this.IntArr = new int[size];
                        IntArr[size - 1] = value;

                        for (int i = 0; i < size - 1; i++)
                        {
                            IntArr[i] = TempIntArr[i];
                        }
                        break;
                    case "float":
                        this.TempFloatArr = new float[size];
                        for (int i = 0; i < size; i++)
                        {
                            TempFloatArr[i] = FloatArr[i];
                        }
                        size += 1;
                        this.FloatArr = new float[size];
                        FloatArr[size - 1] = value;

                        for (int i = 0; i < size - 1; i++)
                        {
                            FloatArr[i] = TempFloatArr[i];
                        }
                        break;
                    case "double":
                        this.TempDoubleArr = new double[size];
                        for (int i = 0; i < size; i++)
                        {
                            TempDoubleArr[i] = DoubleArr[i];
                        }
                        size += 1;
                        this.DoubleArr = new double[size];
                        DoubleArr[size - 1] = value;

                        for (int i = 0; i < size - 1; i++)
                        {
                            DoubleArr[i] = TempDoubleArr[i];
                        }
                        break;
                    case "byte":
                        this.TempByteArr = new byte[size];
                        for (int i = 0; i < size; i++)
                        {
                            TempByteArr[i] = ByteArr[i];
                        }
                        size += 1;
                        this.ByteArr = new byte[size];
                        ByteArr[size - 1] = value;

                        for (int i = 0; i < size - 1; i++)
                        {
                            ByteArr[i] = TempByteArr[i];
                        }
                        break;
                    case "sbyte":
                        this.TempSByteArr = new sbyte[size];
                        for (int i = 0; i < size; i++)
                        {
                            TempSByteArr[i] = SByteArr[i];
                        }
                        size += 1;
                        this.SByteArr = new sbyte[size];
                        SByteArr[size - 1] = value;

                        for (int i = 0; i < size - 1; i++)
                        {
                            SByteArr[i] = TempSByteArr[i];
                        }
                        break;
                    case "uint":
                        this.TempUIntArr = new uint[size];
                        for (int i = 0; i < size; i++)
                        {
                            TempUIntArr[i] = UIntArr[i];
                        }
                        size += 1;
                        this.UIntArr = new uint[size];
                        UIntArr[size - 1] = value;

                        for (int i = 0; i < size - 1; i++)
                        {
                            UIntArr[i] = TempUIntArr[i];
                        }
                        break;
                    case "short":
                        this.TempShortArr = new short[size];
                        for (int i = 0; i < size; i++)
                        {
                            TempShortArr[i] = ShortArr[i];
                        }
                        size += 1;
                        this.ShortArr = new short[size];
                        ShortArr[size - 1] = value;

                        for (int i = 0; i < size - 1; i++)
                        {
                            ShortArr[i] = TempShortArr[i];
                        }
                        break;
                    case "ushort":
                        this.TempUShortArr = new ushort[size];
                        for (int i = 0; i < size; i++)
                        {
                            TempUShortArr[i] = UShortArr[i];
                        }
                        size += 1;
                        this.UShortArr = new ushort[size];
                        UShortArr[size - 1] = value;

                        for (int i = 0; i < size - 1; i++)
                        {
                            UShortArr[i] = TempUShortArr[i];
                        }
                        break;
                    case "long":
                        this.TempLongArr = new long[size];
                        for (int i = 0; i < size; i++)
                        {
                            TempLongArr[i] = LongArr[i];
                        }
                        size += 1;
                        this.LongArr = new long[size];
                        LongArr[size - 1] = value;

                        for (int i = 0; i < size - 1; i++)
                        {
                            LongArr[i] = TempLongArr[i];
                        }
                        break;
                    case "ulong":
                        this.TempULongArr = new ulong[size];
                        for (int i = 0; i < size; i++)
                        {
                            TempULongArr[i] = ULongArr[i];
                        }
                        size += 1;
                        this.ULongArr = new ulong[size];
                        ULongArr[size - 1] = value;

                        for (int i = 0; i < size - 1; i++)
                        {
                            ULongArr[i] = TempULongArr[i];
                        }
                        break;
                    case "char":
                        this.TempCharArr = new char[size];
                        for (int i = 0; i < size; i++)
                        {
                            TempCharArr[i] = CharArr[i];
                        }
                        size += 1;
                        this.CharArr = new char[size];
                        CharArr[size - 1] = value;

                        for (int i = 0; i < size - 1; i++)
                        {
                            CharArr[i] = TempCharArr[i];
                        }
                        break;
                    case "bool":
                        this.TempBoolArr = new bool[size];
                        for (int i = 0; i < size; i++)
                        {
                            TempBoolArr[i] = BoolArr[i];
                        }
                        size += 1;
                        this.BoolArr = new bool[size];
                        BoolArr[size - 1] = value;

                        for (int i = 0; i < size - 1; i++)
                        {
                            BoolArr[i] = TempBoolArr[i];
                        }
                        break;
                    case "object":
                        this.TempObjectArr = new object[size];
                        for (int i = 0; i < size; i++)
                        {
                            TempObjectArr[i] = ObjectArr[i];
                        }
                        size += 1;
                        this.ObjectArr = new object[size];
                        ObjectArr[size - 1] = value;

                        for (int i = 0; i < size - 1; i++)
                        {
                            ObjectArr[i] = TempObjectArr[i];
                        }
                        break;
                    case "string":
                        this.TempStringArr = new string[size];
                        for (int i = 0; i < size; i++)
                        {
                            TempStringArr[i] = StringArr[i];
                        }
                        size += 1;
                        this.StringArr = new string[size];
                        StringArr[size - 1] = value;

                        for (int i = 0; i < size - 1; i++)
                        {
                            StringArr[i] = TempStringArr[i];
                        }
                        break;
                    case "decimal":
                        this.TempDecimalArr = new decimal[size];
                        for (int i = 0; i < size; i++)
                        {
                            TempDecimalArr[i] = DecimalArr[i];
                        }
                        size += 1;
                        this.DecimalArr = new decimal[size];
                        DecimalArr[size - 1] = value;

                        for (int i = 0; i < size - 1; i++)
                        {
                            DecimalArr[i] = TempDecimalArr[i];
                        }
                        break;
                    case "dynamic":
                        this.TempDynamicArr = new dynamic[size];
                        for (int i = 0; i < size; i++)
                        {
                            TempDynamicArr[i] = DynamicArr[i];
                        }
                        size += 1;
                        this.DynamicArr = new dynamic[size];
                        DynamicArr[size - 1] = value;

                        for (int i = 0; i < size - 1; i++)
                        {
                            DynamicArr[i] = TempDynamicArr[i];
                        }
                        break;
                    case "dynamicarray":
                        this.TempdynamicarrayArr = new dynamicarray[size];
                        for (int i = 0; i < size; i++)
                        {
                            TempdynamicarrayArr[i] = dynamicarrayArr[i];
                        }
                        size += 1;
                        this.dynamicarrayArr = new dynamicarray[size];
                        dynamicarrayArr[size - 1] = value;

                        for (int i = 0; i < size - 1; i++)
                        {
                            dynamicarrayArr[i] = TempdynamicarrayArr[i];
                        }
                        break;
                }
            }
            catch
            {
                throw new Exception("Invalide type of appeneded element!");
            }
        }

        /*
        dynamicarray.insert(index, value) insert the value at the index, in case of invalide index show out of range error message
        */
        public void insert(int index, dynamic value)
        {
            try
            {
                if (index == -1)
                    index = size - 1;
                switch (type)
                {
                    case "int":
                        IntArr[index] = value;
                        break;
                    case "float":
                        FloatArr[index] = value;
                        break;
                    case "double":
                        DoubleArr[index] = value;
                        break;
                    case "byte":
                        ByteArr[index] = value;
                        break;
                    case "sbyte":
                        SByteArr[index] = value;
                        break;
                    case "uint":
                        UIntArr[index] = value;
                        break;
                    case "short":
                        ShortArr[index] = value;
                        break;
                    case "ushort":
                        UShortArr[index] = value;
                        break;
                    case "long":
                        LongArr[index] = value;
                        break;
                    case "ulong":
                        ULongArr[index] = value;
                        break;
                    case "char":
                        CharArr[index] = value;
                        break;
                    case "bool":
                        BoolArr[index] = value;
                        break;
                    case "object":
                        ObjectArr[index] = value;
                        break;
                    case "string":
                        StringArr[index] = value;
                        break;
                    case "decimal":
                        DecimalArr[index] = value;
                        break;
                    case "dynamic":
                        DynamicArr[index] = value;
                        break;
                    case "dynamicarray":
                        dynamicarrayArr[index] = value;
                        break;
                }
            }
            catch
            {
                throw new Exception("The index is out of range!");
            }
        }

        /*
        dynamicarray.Size() return the size of the array
        */

        public int Size()
        {
            return size;
        }

        /*
        dynamicarray.Type() return the type of the array
        */

        public string Type()
        {
            return type;
        }

        /*
        dynamicarray.Clear() remove all value and reset the array
        */

        public void Clear()
        {
            switch (type)
            {
                case "int":
                    IntArr = new int[0];
                    break;
                case "float":
                    FloatArr = new float[0];
                    break;
                case "double":
                    DoubleArr = new double[0];
                    break;
                case "byte":
                    ByteArr = new byte[0];
                    break;
                case "sbyte":
                    SByteArr = new sbyte[0];
                    break;
                case "uint":
                    UIntArr = new uint[0];
                    break;
                case "short":
                    ShortArr = new short[0];
                    break;
                case "ushort":
                    UShortArr = new ushort[0];
                    break;
                case "long":
                    LongArr = new long[0];
                    break;
                case "ulong":
                    ULongArr = new ulong[0];
                    break;
                case "char":
                    CharArr = new char[0];
                    break;
                case "bool":
                    BoolArr = new bool[0];
                    break;
                case "object":
                    ObjectArr = new object[0];
                    break;
                case "string":
                    StringArr = new string[0];
                    break;
                case "decimal":
                    DecimalArr = new decimal[0];
                    break;
                case "dynamic":
                    DynamicArr = new dynamic[0];
                    break;
                case "dynamicarray":
                    dynamicarrayArr = new dynamicarray[0];
                    break;
            }
        }

        /*
        dynamicarray.remove(index) remove the value at index
        dynamicarray.remove(indexstart, indexend) remove all the values start at indexstart and include indexend
        */

        public void remove(int index)
        {
            try
            {
                if (index == -1)
                    index = size - 1;
                switch (type)
                {
                    case "int":
                        newsize = 0;
                        this.TempIntArr = new int[size];
                        for (int i = 0; i < size; i++)
                        {
                            if (i == index)
                                continue;
                            TempIntArr[i] = IntArr[i];
                            newsize++;
                        }
                        size = newsize;
                        this.IntArr = new int[size];
                        for (int i = 0; i < size; i++)
                        {
                            IntArr[i] = TempIntArr[i];
                        }
                        break;
                    case "float":
                        newsize = 0;
                        this.TempFloatArr = new float[size];
                        for (int i = 0; i < size; i++)
                        {
                            if (i == index)
                                continue;
                            TempFloatArr[i] = FloatArr[i];
                            newsize++;
                        }
                        size = newsize;
                        this.FloatArr = new float[size];
                        for (int i = 0; i < size; i++)
                        {
                            FloatArr[i] = TempFloatArr[i];
                        }
                        break;
                    case "double":
                        newsize = 0;
                        this.TempDoubleArr = new double[size];
                        for (int i = 0; i < size; i++)
                        {
                            if (i == index)
                                continue;
                            TempDoubleArr[i] = DoubleArr[i];
                            newsize++;
                        }
                        size = newsize;
                        this.DoubleArr = new double[size];
                        for (int i = 0; i < size; i++)
                        {
                            DoubleArr[i] = TempDoubleArr[i];
                        }
                        break;
                    case "byte":
                        newsize = 0;
                        this.TempByteArr = new byte[size];
                        for (int i = 0; i < size; i++)
                        {
                            if (i == index)
                                continue;
                            TempByteArr[i] = ByteArr[i];
                            newsize++;
                        }
                        size = newsize;
                        this.ByteArr = new byte[size];
                        for (int i = 0; i < size; i++)
                        {
                            ByteArr[i] = TempByteArr[i];
                        }
                        break;
                    case "sbyte":
                        newsize = 0;
                        this.TempSByteArr = new sbyte[size];
                        for (int i = 0; i < size; i++)
                        {
                            if (i == index)
                                continue;
                            TempSByteArr[i] = SByteArr[i];
                            newsize++;
                        }
                        size = newsize;
                        this.SByteArr = new sbyte[size];
                        for (int i = 0; i < size; i++)
                        {
                            SByteArr[i] = TempSByteArr[i];
                        }
                        break;
                    case "uint":
                        newsize = 0;
                        this.TempUIntArr = new uint[size];
                        for (int i = 0; i < size; i++)
                        {
                            if (i == index)
                                continue;
                            TempUIntArr[i] = UIntArr[i];
                            newsize++;
                        }
                        size = newsize;
                        this.UIntArr = new uint[size];
                        for (int i = 0; i < size; i++)
                        {
                            UIntArr[i] = TempUIntArr[i];
                        }
                        break;
                    case "short":
                        newsize = 0;
                        this.TempShortArr = new short[size];
                        for (int i = 0; i < size; i++)
                        {
                            if (i == index)
                                continue;
                            TempShortArr[i] = ShortArr[i];
                            newsize++;
                        }
                        size = newsize;
                        this.ShortArr = new short[size];
                        for (int i = 0; i < size; i++)
                        {
                            ShortArr[i] = TempShortArr[i];
                        }
                        break;
                    case "ushort":
                        newsize = 0;
                        this.TempUShortArr = new ushort[size];
                        for (int i = 0; i < size; i++)
                        {
                            if (i == index)
                                continue;
                            TempUShortArr[i] = UShortArr[i];
                            newsize++;
                        }
                        size = newsize;
                        this.UShortArr = new ushort[size];
                        for (int i = 0; i < size; i++)
                        {
                            UShortArr[i] = TempUShortArr[i];
                        }
                        break;
                    case "long":
                        newsize = 0;
                        this.TempLongArr = new long[size];
                        for (int i = 0; i < size; i++)
                        {
                            if (i == index)
                                continue;
                            TempLongArr[i] = LongArr[i];
                            newsize++;
                        }
                        size = newsize;
                        this.LongArr = new long[size];
                        for (int i = 0; i < size; i++)
                        {
                            LongArr[i] = TempLongArr[i];
                        }
                        break;
                    case "ulong":
                        newsize = 0;
                        this.TempULongArr = new ulong[size];
                        for (int i = 0; i < size; i++)
                        {
                            if (i == index)
                                continue;
                            TempULongArr[i] = ULongArr[i];
                            newsize++;
                        }
                        size = newsize;
                        this.ULongArr = new ulong[size];
                        for (int i = 0; i < size; i++)
                        {
                            ULongArr[i] = TempULongArr[i];
                        }
                        break;
                    case "char":
                        newsize = 0;
                        this.TempCharArr = new char[size];
                        for (int i = 0; i < size; i++)
                        {
                            if (i == index)
                                continue;
                            TempCharArr[i] = CharArr[i];
                            newsize++;
                        }
                        size = newsize;
                        this.CharArr = new char[size];
                        for (int i = 0; i < size; i++)
                        {
                            CharArr[i] = TempCharArr[i];
                        }
                        break;
                    case "bool":
                        newsize = 0;
                        this.TempBoolArr = new bool[size];
                        for (int i = 0; i < size; i++)
                        {
                            if (i == index)
                                continue;
                            TempBoolArr[i] = BoolArr[i];
                            newsize++;
                        }
                        size = newsize;
                        this.BoolArr = new bool[size];
                        for (int i = 0; i < size; i++)
                        {
                            BoolArr[i] = TempBoolArr[i];
                        }
                        break;
                    case "object":
                        newsize = 0;
                        this.TempObjectArr = new object[size];
                        for (int i = 0; i < size; i++)
                        {
                            if (i == index)
                                continue;
                            TempObjectArr[i] = ObjectArr[i];
                            newsize++;
                        }
                        size = newsize;
                        this.ObjectArr = new object[size];
                        for (int i = 0; i < size; i++)
                        {
                            ObjectArr[i] = TempObjectArr[i];
                        }
                        break;
                    case "string":
                        newsize = 0;
                        this.TempStringArr = new string[size];
                        for (int i = 0; i < size; i++)
                        {
                            if (i == index)
                                continue;
                            TempStringArr[i] = StringArr[i];
                            newsize++;
                        }
                        size = newsize;
                        this.StringArr = new string[size];
                        for (int i = 0; i < size; i++)
                        {
                            StringArr[i] = TempStringArr[i];
                        }
                        break;
                    case "decimal":
                        newsize = 0;
                        this.TempDecimalArr = new decimal[size];
                        for (int i = 0; i < size; i++)
                        {
                            if (i == index)
                                continue;
                            TempDecimalArr[i] = DecimalArr[i];
                            newsize++;
                        }
                        size = newsize;
                        this.DecimalArr = new decimal[size];
                        for (int i = 0; i < size; i++)
                        {
                            DecimalArr[i] = TempDecimalArr[i];
                        }
                        break;
                    case "dynamic":
                        newsize = 0;
                        this.TempDynamicArr = new dynamic[size];
                        for (int i = 0; i < size; i++)
                        {
                            if (i == index)
                                continue;
                            TempDynamicArr[i] = DynamicArr[i];
                            newsize++;
                        }
                        size = newsize;
                        this.DynamicArr = new dynamic[size];
                        for (int i = 0; i < size; i++)
                        {
                            DynamicArr[i] = TempDynamicArr[i];
                        }
                        break;
                    case "dynamicarray":
                        newsize = 0;
                        this.TempdynamicarrayArr = new dynamicarray[size];
                        for (int i = 0; i < size; i++)
                        {
                            if (i == index)
                                continue;
                            TempdynamicarrayArr[i] = dynamicarrayArr[i];
                            newsize++;
                        }
                        size = newsize;
                        this.dynamicarrayArr = new dynamicarray[size];
                        for (int i = 0; i < size; i++)
                        {
                            dynamicarrayArr[i] = TempdynamicarrayArr[i];
                        }
                        break;
                }
            }
            catch
            {
                throw new Exception("The index is out of range!");
            }
        }

        public void remove(int indexstart, int indexend)
        {
            try
            {
                if (indexend == -1)
                    indexend = size - 1;
                switch (type)
                {
                    case "int":
                        newsize = 0;
                        this.TempIntArr = new int[size];
                        for (int i = 0; i < size; i++)
                        {
                            if (i >= indexstart && i <= indexend)
                                continue;
                            TempIntArr[i] = IntArr[i];
                            newsize++;
                        }
                        size = newsize;
                        this.IntArr = new int[size];
                        for (int i = 0; i < size; i++)
                        {
                            IntArr[i] = TempIntArr[i];
                        }
                        break;
                    case "float":
                        newsize = 0;
                        this.TempFloatArr = new float[size];
                        for (int i = 0; i < size; i++)
                        {
                            if (i >= indexstart && i <= indexend)
                                continue;
                            TempFloatArr[i] = FloatArr[i];
                            newsize++;
                        }
                        size = newsize;
                        this.FloatArr = new float[size];
                        for (int i = 0; i < size; i++)
                        {
                            FloatArr[i] = TempFloatArr[i];
                        }
                        break;
                    case "double":
                        newsize = 0;
                        this.TempDoubleArr = new double[size];
                        for (int i = 0; i < size; i++)
                        {
                            if (i >= indexstart && i <= indexend)
                                continue;
                            TempDoubleArr[i] = DoubleArr[i];
                            newsize++;
                        }
                        size = newsize;
                        this.DoubleArr = new double[size];
                        for (int i = 0; i < size; i++)
                        {
                            DoubleArr[i] = TempDoubleArr[i];
                        }
                        break;
                    case "byte":
                        newsize = 0;
                        this.TempByteArr = new byte[size];
                        for (int i = 0; i < size; i++)
                        {
                            if (i >= indexstart && i <= indexend)
                                continue;
                            TempByteArr[i] = ByteArr[i];
                            newsize++;
                        }
                        size = newsize;
                        this.ByteArr = new byte[size];
                        for (int i = 0; i < size; i++)
                        {
                            ByteArr[i] = TempByteArr[i];
                        }
                        break;
                    case "sbyte":
                        newsize = 0;
                        this.TempSByteArr = new sbyte[size];
                        for (int i = 0; i < size; i++)
                        {
                            if (i >= indexstart && i <= indexend)
                                continue;
                            TempSByteArr[i] = SByteArr[i];
                            newsize++;
                        }
                        size = newsize;
                        this.SByteArr = new sbyte[size];
                        for (int i = 0; i < size; i++)
                        {
                            SByteArr[i] = TempSByteArr[i];
                        }
                        break;
                    case "uint":
                        newsize = 0;
                        this.TempUIntArr = new uint[size];
                        for (int i = 0; i < size; i++)
                        {
                            if (i >= indexstart && i <= indexend)
                                continue;
                            TempUIntArr[i] = UIntArr[i];
                            newsize++;
                        }
                        size = newsize;
                        this.UIntArr = new uint[size];
                        for (int i = 0; i < size; i++)
                        {
                            UIntArr[i] = TempUIntArr[i];
                        }
                        break;
                    case "short":
                        newsize = 0;
                        this.TempShortArr = new short[size];
                        for (int i = 0; i < size; i++)
                        {
                            if (i >= indexstart && i <= indexend)
                                continue;
                            TempShortArr[i] = ShortArr[i];
                            newsize++;
                        }
                        size = newsize;
                        this.ShortArr = new short[size];
                        for (int i = 0; i < size; i++)
                        {
                            ShortArr[i] = TempShortArr[i];
                        }
                        break;
                    case "ushort":
                        newsize = 0;
                        this.TempUShortArr = new ushort[size];
                        for (int i = 0; i < size; i++)
                        {
                            if (i >= indexstart && i <= indexend)
                                continue;
                            TempUShortArr[i] = UShortArr[i];
                            newsize++;
                        }
                        size = newsize;
                        this.UShortArr = new ushort[size];
                        for (int i = 0; i < size; i++)
                        {
                            UShortArr[i] = TempUShortArr[i];
                        }
                        break;
                    case "long":
                        newsize = 0;
                        this.TempLongArr = new long[size];
                        for (int i = 0; i < size; i++)
                        {
                            if (i >= indexstart && i <= indexend)
                                continue;
                            TempLongArr[i] = LongArr[i];
                            newsize++;
                        }
                        size = newsize;
                        this.LongArr = new long[size];
                        for (int i = 0; i < size; i++)
                        {
                            LongArr[i] = TempLongArr[i];
                        }
                        break;
                    case "ulong":
                        newsize = 0;
                        this.TempULongArr = new ulong[size];
                        for (int i = 0; i < size; i++)
                        {
                            if (i >= indexstart && i <= indexend)
                                continue;
                            TempULongArr[i] = ULongArr[i];
                            newsize++;
                        }
                        size = newsize;
                        this.ULongArr = new ulong[size];
                        for (int i = 0; i < size; i++)
                        {
                            ULongArr[i] = TempULongArr[i];
                        }
                        break;
                    case "char":
                        newsize = 0;
                        this.TempCharArr = new char[size];
                        for (int i = 0; i < size; i++)
                        {
                            if (i >= indexstart && i <= indexend)
                                continue;
                            TempCharArr[i] = CharArr[i];
                            newsize++;
                        }
                        size = newsize;
                        this.CharArr = new char[size];
                        for (int i = 0; i < size; i++)
                        {
                            CharArr[i] = TempCharArr[i];
                        }
                        break;
                    case "bool":
                        newsize = 0;
                        this.TempBoolArr = new bool[size];
                        for (int i = 0; i < size; i++)
                        {
                            if (i >= indexstart && i <= indexend)
                                continue;
                            TempBoolArr[i] = BoolArr[i];
                            newsize++;
                        }
                        size = newsize;
                        this.BoolArr = new bool[size];
                        for (int i = 0; i < size; i++)
                        {
                            BoolArr[i] = TempBoolArr[i];
                        }
                        break;
                    case "object":
                        newsize = 0;
                        this.TempObjectArr = new object[size];
                        for (int i = 0; i < size; i++)
                        {
                            if (i >= indexstart && i <= indexend)
                                continue;
                            TempObjectArr[i] = ObjectArr[i];
                            newsize++;
                        }
                        size = newsize;
                        this.ObjectArr = new object[size];
                        for (int i = 0; i < size; i++)
                        {
                            ObjectArr[i] = TempObjectArr[i];
                        }
                        break;
                    case "string":
                        newsize = 0;
                        this.TempStringArr = new string[size];
                        for (int i = 0; i < size; i++)
                        {
                            if (i >= indexstart && i <= indexend)
                                continue;
                            TempStringArr[i] = StringArr[i];
                            newsize++;
                        }
                        size = newsize;
                        this.StringArr = new string[size];
                        for (int i = 0; i < size; i++)
                        {
                            StringArr[i] = TempStringArr[i];
                        }
                        break;
                    case "decimal":
                        newsize = 0;
                        this.TempDecimalArr = new decimal[size];
                        for (int i = 0; i < size; i++)
                        {
                            if (i >= indexstart && i <= indexend)
                                continue;
                            TempDecimalArr[i] = DecimalArr[i];
                            newsize++;
                        }
                        size = newsize;
                        this.DecimalArr = new decimal[size];
                        for (int i = 0; i < size; i++)
                        {
                            DecimalArr[i] = TempDecimalArr[i];
                        }
                        break;
                    case "dynamic":
                        newsize = 0;
                        this.TempDynamicArr = new dynamic[size];
                        for (int i = 0; i < size; i++)
                        {
                            if (i >= indexstart && i <= indexend)
                                continue;
                            TempDynamicArr[i] = DynamicArr[i];
                            newsize++;
                        }
                        size = newsize;
                        this.DynamicArr = new dynamic[size];
                        for (int i = 0; i < size; i++)
                        {
                            DynamicArr[i] = TempDynamicArr[i];
                        }
                        break;
                    case "dynamicarray":
                        newsize = 0;
                        this.TempdynamicarrayArr = new dynamicarray[size];
                        for (int i = 0; i < size; i++)
                        {
                            if (i >= indexstart && i <= indexend)
                                continue;
                            TempdynamicarrayArr[i] = dynamicarrayArr[i];
                            newsize++;
                        }
                        size = newsize;
                        this.dynamicarrayArr = new dynamicarray[size];
                        for (int i = 0; i < size; i++)
                        {
                            dynamicarrayArr[i] = TempdynamicarrayArr[i];
                        }
                        break;
                }
            }
            catch
            {
                throw new Exception("The index is out of range!");
            }
        }

        /*
        dynamicarray.fill(indexstart, indexend, value) change all the values in the array between those index, including it for the new value in params
        */
        public void fill(int indexstart, int indexend, dynamic value)
        {
            try
            {
                if (indexend == -1)
                    indexend = size - 1;
                for (int i = indexstart; i <= indexend; i++)
                {
                    this.insert(i, value);
                }
            }
            catch
            {
                throw new Exception("The index is out of range!");
            }
        }

        /*
        dynamicarr1.copy(dynamicarr2) copy the second arr to the first arr
        */
        public void copy(dynamicarray arr)
        {
            this.Clear();
            this.type = arr.Type();
            this.size = arr.Size();
            switch (arr.Type()) {
                case "int": 
                    this.IntArr = new int[arr.Size()];
                    for (int i = 0; i < arr.Size(); i++)
                    {
                        this.IntArr[i] = arr.IntArr[i];
                    }
                    break;
                case "float":
                    this.FloatArr = new float[arr.Size()];
                    for (int i = 0; i < arr.Size(); i++)
                    {
                        this.FloatArr[i] = arr.FloatArr[i];
                    }
                    break;
                case "double":
                    this.DoubleArr = new double[arr.Size()];
                    for (int i = 0; i < arr.Size(); i++)
                    {
                        this.DoubleArr[i] = arr.DoubleArr[i];
                    }
                    break;
                case "byte":
                    this.ByteArr = new byte[arr.Size()];
                    for (int i = 0; i < arr.Size(); i++)
                    {
                        this.ByteArr[i] = arr.ByteArr[i];
                    }
                    break;
                case "sbyte":
                    this.SByteArr = new sbyte[arr.Size()];
                    for (int i = 0; i < arr.Size(); i++)
                    {
                        this.SByteArr[i] = arr.SByteArr[i];
                    }
                    break;
                case "uint":
                    this.UIntArr = new uint[arr.Size()];
                    for (int i = 0; i < arr.Size(); i++)
                    {
                        this.UIntArr[i] = arr.UIntArr[i];
                    }
                    break;
                case "short":
                    this.ShortArr = new short[arr.Size()];
                    for (int i = 0; i < arr.Size(); i++)
                    {
                        this.ShortArr[i] = arr.ShortArr[i];
                    }
                    break;
                case "ushort":
                    this.UShortArr = new ushort[arr.Size()];
                    for (int i = 0; i < arr.Size(); i++)
                    {
                        this.UShortArr[i] = arr.UShortArr[i];
                    }
                    break;
                case "long":
                    this.LongArr = new long[arr.Size()];
                    for (int i = 0; i < arr.Size(); i++)
                    {
                        this.LongArr[i] = arr.LongArr[i];
                    }
                    break;
                case "ulong":
                    this.ULongArr = new ulong[arr.Size()];
                    for (int i = 0; i < arr.Size(); i++)
                    {
                        this.ULongArr[i] = arr.ULongArr[i];
                    }
                    break;
                case "char":
                    this.CharArr = new char[arr.Size()];
                    for (int i = 0; i < arr.Size(); i++)
                    {
                        this.CharArr[i] = arr.CharArr[i];
                    }
                    break;
                case "bool":
                    this.BoolArr = new bool[arr.Size()];
                    for (int i = 0; i < arr.Size(); i++)
                    {
                        this.BoolArr[i] = arr.BoolArr[i];
                    }
                    break;
                case "object":
                    this.ObjectArr = new object[arr.Size()];
                    for (int i = 0; i < arr.Size(); i++)
                    {
                        this.ObjectArr[i] = arr.ObjectArr[i];
                    }
                    break;
                case "string":
                    this.StringArr = new string[arr.Size()];
                    for (int i = 0; i < arr.Size(); i++)
                    {
                        this.StringArr[i] = arr.StringArr[i];
                    }
                    break;
                case "decimal":
                    this.DecimalArr = new decimal[arr.Size()];
                    for (int i = 0; i < arr.Size(); i++)
                    {
                        this.DecimalArr[i] = arr.DecimalArr[i];
                    }
                    break;
                case "dynamic":
                    this.DynamicArr = new dynamic[arr.Size()];
                    for (int i = 0; i < arr.Size(); i++)
                    {
                        this.DynamicArr[i] = arr.DynamicArr[i];
                    }
                    break;
                case "dynamicarray":
                    this.dynamicarrayArr = new dynamicarray[arr.Size()];
                    for (int i = 0; i < arr.Size(); i++)
                    {
                        this.dynamicarrayArr[i] = arr.dynamicarrayArr[i];
                    }
                    break;
            }
        }

        /*
        dynamicarray.sort() sort the array
        */
        public void sort()
        {
            switch (this.Type())
            {
                case "int":
                    bool iV;
                    for (int i = 0; i < this.Size() - 1; i++)
                    {
                        iV = false;
                        for (int j = 0; j < this.Size() - i - 1; j++)
                        {
                            if (IntArr[j] > IntArr[j + 1])
                            {
                                int temp;
                                temp = IntArr[j];
                                IntArr[j] = IntArr[j + 1];
                                IntArr[j + 1] = temp;
                                iV = true;
                            }
                        }
                        if (!iV)
                            break;
                    }
                    break;
                case "float":
                    bool fV;
                    for (int i = 0; i < this.Size() - 1; i++)
                    {
                        fV = false;
                        for (int j = 0; j < this.Size() - i - 1; j++)
                        {
                            if (FloatArr[j] > FloatArr[j + 1])
                            {
                                float temp;
                                temp = FloatArr[j];
                                FloatArr[j] = FloatArr[j + 1];
                                FloatArr[j + 1] = temp;
                                fV = true;
                            }
                        }
                        if (!fV)
                            break;
                    }
                    break;
                case "double":
                    bool dV;
                    for (int i = 0; i < this.Size() - 1; i++)
                    {
                        dV = false;
                        for (int j = 0; j < this.Size() - i - 1; j++)
                        {
                            if (DoubleArr[j] > DoubleArr[j + 1])
                            {
                                double temp;
                                temp = DoubleArr[j];
                                DoubleArr[j] = DoubleArr[j + 1];
                                DoubleArr[j + 1] = temp;
                                dV = true;
                            }
                        }
                        if (!dV)
                            break;
                    }
                    break;
                case "byte":
                    bool bV;
                    for (int i = 0; i < this.Size() - 1; i++)
                    {
                        bV = false;
                        for (int j = 0; j < this.Size() - i - 1; j++)
                        {
                            if (ByteArr[j] > ByteArr[j + 1])
                            {
                                byte temp;
                                temp = ByteArr[j];
                                ByteArr[j] = ByteArr[j + 1];
                                ByteArr[j + 1] = temp;
                                bV = true;
                            }
                        }
                        if (!bV)
                            break;
                    }
                    break;
                case "sbyte":
                    bool sbV;
                    for (int i = 0; i < this.Size() - 1; i++)
                    {
                        sbV = false;
                        for (int j = 0; j < this.Size() - i - 1; j++)
                        {
                            if (SByteArr[j] > SByteArr[j + 1])
                            {
                                sbyte temp;
                                temp = SByteArr[j];
                                SByteArr[j] = SByteArr[j + 1];
                                SByteArr[j + 1] = temp;
                                sbV = true;
                            }
                        }
                        if (!sbV)
                            break;
                    }
                    break;
                case "uint":
                    bool uitV;
                    for (int i = 0; i < this.Size() - 1; i++)
                    {
                        uitV = false;
                        for (int j = 0; j < this.Size() - i - 1; j++)
                        {
                            if (UIntArr[j] > UIntArr[j + 1])
                            {
                                uint temp;
                                temp = UIntArr[j];
                                UIntArr[j] = UIntArr[j + 1];
                                UIntArr[j + 1] = temp;
                                uitV = true;
                            }
                        }
                        if (!uitV)
                            break;
                    }
                    break;
                case "short":
                    bool shV;
                    for (int i = 0; i < this.Size() - 1; i++)
                    {
                        shV = false;
                        for (int j = 0; j < this.Size() - i - 1; j++)
                        {
                            if (ShortArr[j] > ShortArr[j + 1])
                            {
                                short temp;
                                temp = ShortArr[j];
                                ShortArr[j] = ShortArr[j + 1];
                                ShortArr[j + 1] = temp;
                                shV = true;
                            }
                        }
                        if (!shV)
                            break;
                    }
                    break;
                case "ushort":
                    bool ushV;
                    for (int i = 0; i < this.Size() - 1; i++)
                    {
                        ushV = false;
                        for (int j = 0; j < this.Size() - i - 1; j++)
                        {
                            if (UShortArr[j] > FloatArr[j + 1])
                            {
                                ushort temp;
                                temp = UShortArr[j];
                                UShortArr[j] = UShortArr[j + 1];
                                UShortArr[j + 1] = temp;
                                ushV = true;
                            }
                        }
                        if (!ushV)
                            break;
                    }
                    break;
                case "long":
                    bool loV;
                    for (int i = 0; i < this.Size() - 1; i++)
                    {
                        loV = false;
                        for (int j = 0; j < this.Size() - i - 1; j++)
                        {
                            if (LongArr[j] > LongArr[j + 1])
                            {
                                long temp;
                                temp = LongArr[j];
                                LongArr[j] = LongArr[j + 1];
                                LongArr[j + 1] = temp;
                                loV = true;
                            }
                        }
                        if (!loV)
                            break;
                    }
                    break;
                case "ulong":
                    bool uloV;
                    for (int i = 0; i < this.Size() - 1; i++)
                    {
                        uloV = false;
                        for (int j = 0; j < this.Size() - i - 1; j++)
                        {
                            if (ULongArr[j] > ULongArr[j + 1])
                            {
                                ulong temp;
                                temp = ULongArr[j];
                                ULongArr[j] = ULongArr[j + 1];
                                ULongArr[j + 1] = temp;
                                uloV = true;
                            }
                        }
                        if (!uloV)
                            break;
                    }
                    break;
                case "char":
                    bool crV;
                    for (int i = 0; i < this.Size() - 1; i++)
                    {
                        crV = false;
                        for (int j = 0; j < this.Size() - i - 1; j++)
                        {
                            if (CharArr[j] > CharArr[j + 1])
                            {
                                char temp;
                                temp = CharArr[j];
                                CharArr[j] = CharArr[j + 1];
                                CharArr[j + 1] = temp;
                                crV = true;
                            }
                        }
                        if (!crV)
                            break;
                    }
                    break;
                case "bool":
                    bool boV;
                    for (int i = 0; i < this.Size() - 1; i++)
                    {
                        boV = false;
                        for (int j = 0; j < this.Size() - i - 1; j++)
                        {
                            if (Convert.ToInt32(BoolArr[j]) > Convert.ToInt32(BoolArr[j + 1]))
                            {
                                bool temp;
                                temp = BoolArr[j];
                                BoolArr[j] = BoolArr[j + 1];
                                BoolArr[j + 1] = temp;
                                boV = true;
                            }
                        }
                        if (!boV)
                            break;
                    }
                    break;
                case "object":
                    throw new Exception("Impossible to sort this data type");
                case "string":
                    bool strV;
                    for (int i = 0; i < this.Size() - 1; i++)
                    {
                        strV = false;
                        for (int j = 0; j < this.Size() - i - 1; j++)
                        {
                            int k = 0;
                            string str1 = StringArr[j], str2 = StringArr[j + 1];
                            while (k < str1.Length && k < str2.Length)
                            {
                                if (str1[k] < str2[k])
                                {
                                    break;
                                }
                                else if (str1[k] > str2[k])
                                {
                                    string temp;
                                    temp = StringArr[j];
                                    StringArr[j] = StringArr[j + 1];
                                    StringArr[j + 1] = temp;
                                    strV = true;
                                    break;
                                }
                                k++;
                            }
                        }
                        if (!strV)
                            break;
                    }
                    break;
                case "decimal":
                    bool deV;
                    for (int i = 0; i < this.Size() - 1; i++)
                    {
                        deV = false;
                        for (int j = 0; j < this.Size() - i - 1; j++)
                        {
                            if (DecimalArr[j] > DecimalArr[j + 1])
                            {
                                decimal temp;
                                temp = DecimalArr[j];
                                DecimalArr[j] = DecimalArr[j + 1];
                                DecimalArr[j + 1] = temp;
                                deV = true;
                            }
                        }
                        if (!deV)
                            break;
                    }
                    break;
                case "dynamic":
                    bool dcV;
                    for (int i = 0; i < this.Size() - 1; i++)
                    {
                        dcV = false;
                        for (int j = 0; j < this.Size() - i - 1; j++)
                        {
                            if (DynamicArr[j] > DynamicArr[j + 1])
                            {
                                dynamic temp;
                                temp = DynamicArr[j];
                                DynamicArr[j] = DynamicArr[j + 1];
                                DynamicArr[j + 1] = temp;
                                dcV = true;
                            }
                        }
                        if (!dcV)
                            break;
                    }
                    break;
                case "dynamicarray":
                    throw new Exception("Impossible to sort this data type");
            }
        }

        public void reverse()
        {
            switch (this.Type())
            {
                case "int":
                    TempIntArr = new int[this.Size()];
                    for (int i = this.Size() - 1; i >= 0; i--)
                    {
                        TempIntArr[i] = IntArr[this.Size() - i - 1];
                    }
                    for (int i = 0; i < this.Size(); i++)
                    {
                        IntArr[i] = TempIntArr[i];
                    }
                    break;
                case "float":
                    break;
                case "double":
                    break;
                case "byte":
                    break;
                case "sbyte":
                    break;
                case "uint":
                    break;
                case "short":
                    break;
                case "ushort":
                    break;
                case "long":
                    break;
                case "ulong":
                    break;
                case "char":
                    break;
                case "bool":
                    break;
                case "object":
                    break;
                case "string":
                    break;
                case "decimal":
                    break;
                case "dynamic":
                    break;
                case "dynamicarray":
                    break;
                }
            }

        /*
        dynamicarray.at(index) return the value at the index. Here are some tricks:
        dynamicarray.at(-1) return the last value
        dynamicarray.at(x) return the value at index x
        dynamicarray.at(dynamicarray.size()) return error "out_of_range"
        */
        public dynamic at(int index)
        {
            try
            {
                if (index == -1)
                    index = size - 1;
                switch (type)
                {
                    case "int": return IntArr[index];
                    case "float": return FloatArr[index];
                    case "double": return DoubleArr[index];
                    case "byte": return ByteArr[index];
                    case "sbyte": return SByteArr[index];
                    case "uint": return UIntArr[index];
                    case "short": return ShortArr[index];
                    case "ushort": return UShortArr[index];
                    case "long": return LongArr[index];
                    case "ulong": return ULongArr[index];
                    case "char": return CharArr[index];
                    case "bool": return BoolArr[index];
                    case "object": return ObjectArr[index];
                    case "string": return StringArr[index];
                    case "decimal": return DecimalArr[index];
                    case "dynamic": return DynamicArr[index];
                    default: return dynamicarrayArr[index];
                }
            }
            catch
            {
                throw new Exception("The index is out of range!");
            }
        }
    }
}
