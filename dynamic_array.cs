using System;

namespace DynamicArray
{
    class dynamicarray<T>
    {
        /*
        Creating new array to manage all datas 
        */

        private T[] Arr, Temp;
        
        public dynamicarray(int size) { Arr = new T[size]; }

        /*
        dynamicarray.push_front(value) add value on front 
        dynamicarray.push_back(value) add value on back
        */
        
        public void push_front(T value)
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
       
        public void push_back(dynamic value)
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
        dynamicarray.insert(index, value) insert the value at the index, in case of invalide index or invalide type of value show error message

        * use -1 as index to insert value in the last element
        */

        public void insert(int index, dynamic value)
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
        dynamicarray.Size() return the size of the array
        */

        public int Size() { return Arr.Length; }

        /*
        dynamicarray.Clear() remove all value and reset the array
        */

        public void Clear() { Arr = new T[0]; }

        /*
        dynamicarray.remove(index) remove the value at index
        dynamicarray.remove(indexstart, indexend) remove all between the values from indexstart to indexend
        */

        public void remove(int index)
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

        public void remove(int indexstart, int indexend)
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
        dynamicarray.at(index) return the value at the index. Here are some tricks:
        dynamicarray.at(-1) return the last value
        dynamicarray.at(x) return the value at index x
        dynamicarray.at(dynamicarray.size()) return error "out_of_range"
        */

        public T at(int index) { if (index == -1) index = Arr.Length - 1;  return this.Arr[index]; }

        /*
        dynamicarray.fill(indexstart, indexend, value) change all the values in the array between those index, including it for the new value in params
        */

        public void fill(int indexstart, int indexend, dynamic value)
        {
            try
            {
                if (indexend == -1)
                    indexend = Arr.Length - 1;
                if (indexstart == -1)
                    indexstart = Arr.Length - 1;
                for (int i = indexstart; i <= indexend; i++)
                {
                    this.insert(i, value);
                }
            }
            catch { throw new Exception("The index is out of range!"); }
        }

        /*
        dynamicarr1.copy(dynamicarr2) copy the second arr to the first arr
        */

        public void copy(dynamicarray<T> Arr2)
        {
            Arr = new T[Arr2.Size()];
            for (int i = 0; i < Arr.Length; i++) { Arr[i] = Arr2.Arr[i]; }
        }

        /*
        dynamicarray.sort() sort the array
        */

        public void sort()
        {
            try
            {
                bool bV;
                for (int i = 0; i < this.Size() - 1; i++)
                {
                    bV = false;
                    for (int j = 0; j < this.Size() - i - 1; j++)
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
        dynamicarray.reverse() reverse all the values in the array 
        */
        public void reverse()
        {
            Temp = new T[this.Size()];
            for (int i = this.Size() - 1; i >= 0; i--)
            {
                Temp[i] = Arr[this.Size() - i - 1];
            }
            for (int i = 0; i < this.Size(); i++)
            {
                Arr[i] = Temp[i];
            }
            Temp = new T[0];
        }

        /*
        dynamicarray.find(value) return the index of the array, if the value is not found the returned index is -1
        */
        public int find(T value)
        {
            for (int i = 0; i < Arr.Length; i++)
            {
                if (value.Equals(Arr[i]))
                    return i;
            }
            return -1;
        }

        /*
        dynamicarray.add(dynamicarray2) add to the dynamicarray the dynamicarray2 
        */
        public void add(dynamicarray<T> Arr2)
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
