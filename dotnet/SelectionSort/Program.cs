// using static Sorting;
// using static Infrastructure;

// // int[] array = CreateArray(10);
// // Show(array);
// // SortSelection(array);
// // Show(array);

// 10.CreateArray(min: 10, max: 5)
//   .Show()
//   .SortSelection()
//   .Show();





using static Sorting;
using static System.Console;

int[] array = {7, 6, 3, 4, 5, 1, 2, 3, 5, 6};

WriteLine($"[{String.Join(',', array)}]");
SortSelection(array);
WriteLine($"[{String.Join(',', array)}]");
