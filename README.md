# Dynamic_Array.cs

Dynamics arrays are array which size is not fixed, you can add value on front, back and use some functions to make your code project easier

## Before start

First to use the dynamic array download the **.cs** file and add it to your C# project
*Add the using part to enemble dynamics arrays in your project*

```using DynamicArray;```

## Array creation

To create an dynamic array use the next C# line

```dynamicarray<type> array = new dynamicarray<type>(size);```

<pre>< type > : the type is the type of values inside the array<br>
array    : is the array name<br>
size     : is the default size in int type, if you don't know what size you need use 0 as a empty array</pre><br>

## Array functions
1. Push_front and push_back functions <br>
```array.push_front(value1);``` <br>
*Add the value1 at the front of the array*<br><br>
```array.push_back(value2);```<br>
*Add the value2 at the back of the array*<br><br>

2. Insert function <br>
```array.insert(index, value);``` <br>
*Set the value at index index for value*<br><br>
```array.insert(-1, value);```<br>
*Set the value at the last index for value*<br><br>

3. Size and clear functions <br>
```array.Size();``` <br>
*Return the size of the array*<br><br>
```array.Clear();```<br>
*Reset the array to size 0 and erase all values*<br><br>

4. Remove functions <br>
```array.remove(index);``` <br>
*Erase the value at the index from the array*<br><br>
```array.remove(indexstart, indexend);```<br>
*Erase all values from indexstart to indexend, including the values at indexstart and indexend*<br><br>
```array.remove(indexstart, -1);```<br>
*Erase all values from indexstart to the end of the array, including the values at indexstart and the last value*<br><br>

5. At functions <br>
```array.at(index);``` <br>
*Return the value at the index*<br><br>

6. Fill functions <br>
```array.fill(indexstart, indexend, value);``` <br>
*Replace all index in array from indexstart to indexend by the value, including the indexstart and indexend*<br><br>

7. Copy and sort functions <br>
```array.copy(array2);``` <br>
*Copy the array2 to the array*<br><br>
```array.sort();``` <br>
*Sort the array*<br><br>

8. Reverse functions <br>
```array.reverse();``` <br>
*Return the reversed array*<br><br>

9. Find functions <br>
```array.find(value);``` <br>
*Return the first index of the value*<br><br>

10. Add functions <br>
```array.add(array2);``` <br>
*Add the array2 to the array*<br><br>

## Code example

```
using System;
using DynamicArray;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            dynamicarray<int> array = new dynamicarray<int>(5);
            for (int i = 0; i < array.Size(); i++)
                array.insert(i, i);

            dynamicarray<int> array2 = new dynamicarray<int>(0); ;
            array2.copy(array);
            array2.add(array);

            array2.sort();
            array2.reverse();
            array2.remove(6, -1);
            array2.fill(0, 1, -3);
            array2.push_front(-10);
            array2.push_back(100);
            int index = array2.find(-3);

            Console.WriteLine(index);
            for (int i = 0; i < array2.Size(); i++)
            {
                Console.WriteLine(array2.at(i));
            }

            array2.Clear();
            Console.WriteLine(array2.Size());

            Console.ReadKey();
        }    
    }
}
```

<br>**OUTPUT:**<br>
```
1
-10
-3
-3
3
3
2
2
100
0
```
## License
**The MIT License** <br><br>
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
