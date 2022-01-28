using System;

namespace DynamicArray
{
    class DynamicArray<T>
    {
        /*
        Creating new array to manage all datas 
        */

        private T[] Arr, Temp;
        
        public DynamicArray(int size) { Arr = new T[size]; }

        /*
        DynamicArray.PushFront(value) Add value on front 
        DynamicArray.PushBack(value) Add value on back
        */
        
        public void PushFront(T value)
        {
            try
            {
                Temp = new T[Arr.Length];
                Array.Copy(Arr, Temp, Temp.Length);
                Arr = new T[Temp.Length + 1];
                Arr[0] = value;
                for (int i = 1; i < Arr.Length; i++)
                    Arr[i] = Temp[i - 1];
                Temp = new T[0];
            }
            catch { throw new Exception("Invalide type of appeneded element!"); }
        }
       
        public void PushBack(T value)
        {
            try
            {
                Temp = new T[Arr.Length];
                Array.Copy(Arr, Temp, Temp.Length);
                Arr = new T[Temp.Length + 1];
                for (int i = 0; i < Arr.Length - 1; i++)
                    Arr[i] = Temp[i];
                Arr[Arr.Length - 1] = value;
                Temp = new T[0];
            }
            catch { throw new Exception("Invalide type of appeneded element!"); }
        }

        /*
        DynamicArray.Insert(index, value) Insert the value At the index, in case of invalide index or invalide type of value show error message

        * use -1 as index to Insert value in the last element
        */

        public void Insert(int index, T value)
        {
            try
            {
                if (index == -1)
                    index = Arr.Length - 1;
                Arr[index] = value;
            }
            catch { throw new Exception("The index is out of range or the type of the value is invalide!"); }
        }

        /*
        DynamicArray.Size() return the size of the array
        */

        public int Size => Arr.Length;

        /*
        DynamicArray.Clear() Remove all value and reset the array
        */

        public void Clear() { Arr = new T[0]; }

        /*
        DynamicArray.Remove(index) Remove the value At index
        DynamicArray.Remove(indexstart, indexend) Remove all between the values from indexstart to indexend
        */

        public void Remove(int index)
        {
            try
            {
                if (index == -1)
                    index = Arr.Length - 1;
                Temp = new T[Arr.Length];
                int j = 0;

                for (int i = 0; i < Arr.Length; i++)
                {
                    if (i == index)
                        continue;
                    Temp[j] = Arr[i];
                    j++;
                }
                Arr = new T[Temp.Length - (Temp.Length - j)];
                for (int i = 0; i < Arr.Length; i++)
                    Arr[i] = Temp[i];
                Temp = new T[0];
            }
            catch { throw new Exception("The index is out of range!"); }
        }

        public void Remove(int indexstart, int indexend)
        {
            try
            {
                if (indexend == -1)
                    indexend = Arr.Length - 1;
                if (indexstart == -1)
                    indexstart = Arr.Length - 1;
                Temp = new T[Arr.Length];
                int j = 0;

                for (int i = 0; i < Arr.Length; i++)
                {
                    if (i >= indexstart && i <= indexend)
                        continue;
                    Temp[j] = Arr[i];
                    j++;
                }
                Arr = new T[Temp.Length - (Temp.Length - j)];
                for (int i = 0; i < Arr.Length; i++)
                    Arr[i] = Temp[i];
                Temp = new T[0];
            }
            catch { throw new Exception("The index is out of range!"); }
        }

        /*
        DynamicArray.At(index) return the value At the index. Here are some tricks:
        DynamicArray.At(-1) return the last value
        DynamicArray.At(x) return the value At index x
        DynamicArray.At(DynamicArray.size()) return error "out_of_range"
        */

        public T At(int index) { if (index == -1) index = Arr.Length - 1;  return this.Arr[index]; }

        /*
        DynamicArray.Fill(indexstart, indexend, value) change all the values in the array between those index, including it for the new value in params
        */

        public void Fill(int indexstart, int indexend, T value)
        {
            try
            {
                if (indexend == -1)
                    indexend = Arr.Length - 1;
                if (indexstart == -1)
                    indexstart = Arr.Length - 1;
                for (int i = indexstart; i <= indexend; i++)
                {
                    this.Insert(i, value);
                }
            }
            catch { throw new Exception("The index is out of range!"); }
        }

        /*
        dynamicarr1.Copy(dynamicarr2) Copy the second arr to the first arr
        */

        public void Copy(DynamicArray<T> Arr2)
        {
            Arr = new T[Arr2.Size];
            for (int i = 0; i < Arr.Length; i++) { Arr[i] = Arr2.Arr[i]; }
        }

        /*
        DynamicArray.Sort() Sort the array
        */

        public void Sort()
        {
            try
            {
                bool bV;
                for (int i = 0; i < this.Size - 1; i++)
                {
                    bV = false;
                    for (int j = 0; j < this.Size - i - 1; j++)
                    {
                        int k = 0;
                        string str1 = Arr[j].ToString(), str2 = Arr[j + 1].ToString();
                        while (k < str1.Length && k < str2.Length)
                        {
                            if (str1[k] < str2[k])
                            {
                                break;
                            }
                            else if (str1[k] > str2[k])
                            {
                                T temp;
                                temp = Arr[j];
                                Arr[j] = Arr[j + 1];
                                Arr[j + 1] = temp;
                                bV = true;
                                break;
                            }
                            k++;
                        }
                    }
                    if (!bV)
                        break;
                }
                Temp = new T[0];
            }
            catch { throw new Exception("The array is unsortable!"); }
        }

        /*
        DynamicArray.Reverse() Reverse all the values in the array 
        */
        public void Reverse()
        {
            Temp = new T[this.Size];
            for (int i = this.Size - 1; i >= 0; i--)
            {
                Temp[i] = Arr[this.Size - i - 1];
            }
            for (int i = 0; i < this.Size; i++)
            {
                Arr[i] = Temp[i];
            }
            Temp = new T[0];
        }

        /*
        DynamicArray.Find(value) return the index of the array, if the value is not found the returned index is -1
        */
        public int Find(T value)
        {
            for (int i = 0; i < Arr.Length; i++)
            {
                if (value.Equals(Arr[i]))
                    return i;
            }
            return -1;
        }

        /*
        DynamicArray.Add(dynamicarray2) Add to the DynamicArray the dynamicarray2 
        */
        public void Add(DynamicArray<T> Arr2)
        {
            Temp = new T[this.Arr.Length];
            for (int i = 0; i < this.Arr.Length; i++) { Temp[i] = this.Arr[i]; }
            Arr = new T[Temp.Length + Arr2.Arr.Length];
            for (int i = 0; i < this.Temp.Length; i++) { Arr[i] = Temp[i]; }
            for (int i = this.Temp.Length; i < Arr.Length; i++) { Arr[i] = Temp[i - Temp.Length]; }
            Temp = new T[0];
        }
    }
}
