## Arrays

Represents a fixed number of variables of a particular type

**Types of Arrays**

- Single Dimension Arrays

```
var numbers = new int[5];

var numbers = new int[5] {1, 2, 3, 4, 5};
```

- Multi Dimension Arrays

```
var matrix = new int[3, 5];

var matrix = new int[3, 5]
{
	{1, 2, 3, 4, 5},
	{6, 7, 8, 9, 10},
	{11, 12, 13, 14, 15}
};

var element = matrix[0,0];
```

```
var array = new int[3][];

array[0] = new int[4];
array[1] = new int[5];
array[2] = new int[3];

array[0][0] =1;
```
___
Next -> [Date and Time](https://github.com/JackieG19/Csharp-Date-and-Time)
