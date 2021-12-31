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
