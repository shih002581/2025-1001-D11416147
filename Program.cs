// 資管系學生學習 C# 變數與資料型別範例（50項）
using System;

class Program
{
    static void Main()
    {
        // 1. int 整數型別
        int a = 10;
        Console.WriteLine($"int a = {a}");
        // 2. float 浮點型別
        float b = 3.14f;
        Console.WriteLine($"float b = {b}");
        // 3. double 雙精度浮點型別
        double c = 2.71828;
        Console.WriteLine($"double c = {c}");
        // 4. char 字元型別
        char d = 'A';
        Console.WriteLine($"char d = {d}");
        // 5. string 字串型別
        string e = "Hello";
        Console.WriteLine($"string e = {e}");
        // 6. bool 布林型別
        bool f = true;
        Console.WriteLine($"bool f = {f}");
        // 7. long 長整數型別
        long g = 1234567890L;
        Console.WriteLine($"long g = {g}");
        // 8. short 短整數型別
        short h = 32000;
        Console.WriteLine($"short h = {h}");
        // 9. uint 無號整數型別
        uint i = 4000000000;
        Console.WriteLine($"uint i = {i}");
        // 10. ulong 無號長整數型別
        ulong j = 9000000000000000000;
        Console.WriteLine($"ulong j = {j}");
        // 11. ushort 無號短整數型別
        ushort k = 65000;
        Console.WriteLine($"ushort k = {k}");
        // 12. byte 位元組型別
        byte l = 255;
        Console.WriteLine($"byte l = {l}");
        // 13. sbyte 有號位元組型別
        sbyte m = -128;
        Console.WriteLine($"sbyte m = {m}");
        // 14. const 常數
        const double PI = 3.14159;
        Console.WriteLine($"const double PI = {PI}");
        // 15. var 型別推斷
        var n = "Type Inference";
        Console.WriteLine($"var n = {n}");
        // 16. object 物件型別
        object o = 123;
        Console.WriteLine($"object o = {o}");
        // 17. dynamic 動態型別
        dynamic p = "Dynamic Value";
        Console.WriteLine($"dynamic p = {p}");
        // 18. int[] 一維陣列
        int[] arr1 = { 1, 2, 3 };
        Console.WriteLine($"int[] arr1 = {{{string.Join(",", arr1)}}}");
        // 19. int[,] 二維陣列
        int[,] arr2 = { { 1, 2 }, { 3, 4 } };
        Console.WriteLine($"int[,] arr2 = {{1,2}},{{3,4}}");
        // 20. enum 列舉型別
        Day today = Day.Friday;
        Console.WriteLine($"enum today = {today}");
        // 21. struct 結構型別
        Point pt = new Point(5, 10);
        Console.WriteLine($"struct pt = ({pt.X},{pt.Y})");
        // 22. Nullable 型別
        int? q = null;
        Console.WriteLine($"int? q = {q}");
        // 23. 字串插值
        string name = "Tom";
        Console.WriteLine($"Hello, {name}");
        // 24. 字串連接
        string s1 = "資管" + "系";
        Console.WriteLine($"string s1 = {s1}");
        // 25. 字串長度
        Console.WriteLine($"s1.Length = {s1.Length}");
        // 26. char.Parse()
        char ch = char.Parse("Z");
        Console.WriteLine($"char ch = {ch}");
        // 27. int.Parse()
        int r = int.Parse("123");
        Console.WriteLine($"int r = {r}");
        // 28. ToString()
        string s2 = r.ToString();
        Console.WriteLine($"string s2 = {s2}");
        // 29. TryParse()
        bool ok = int.TryParse("456", out int s3);
        Console.WriteLine($"TryParse ok = {ok}, s3 = {s3}");
        // 30. 變數交換
        int x = 1, y = 2;
        (x, y) = (y, x);
        Console.WriteLine($"x = {x}, y = {y}");
        // 31. 遞增遞減
        int z = 5;
        z++;
        z--;
        Console.WriteLine($"z = {z}");
        // 32. 運算
        int sum = 1 + 2;
        Console.WriteLine($"sum = {sum}");
        // 33. 複合運算
        sum += 5;
        Console.WriteLine($"sum += 5 -> {sum}");
        // 34. 比較運算
        bool cmp = (sum > 5);
        Console.WriteLine($"sum > 5 = {cmp}");
        // 35. 型別檢查 is
        bool isInt = sum is int;
        Console.WriteLine($"sum is int = {isInt}");
        // 36. 型別轉換 as
        object objStr = "Hello";
        string str2 = objStr as string;
        Console.WriteLine($"str2 = {str2}");
        // 37. 預設值
        int def = default;
        Console.WriteLine($"int default = {def}");
        // 38. 命名慣例
        int myVariable = 100;
        Console.WriteLine($"myVariable = {myVariable}");
        // 39. 可見性 public
        Student stu = new Student();
        Console.WriteLine($"Student.Name = {stu.Name}");
        // 40. private 欄位
        Console.WriteLine($"Student.Age = {stu.GetAge()}");
        // 41. static 靜態變數
        Console.WriteLine($"Student.Count = {Student.Count}");
        // 42. 局部變數
        int localVar = 5;
        Console.WriteLine($"localVar = {localVar}");
        // 43. 全域變數（類別欄位）
        Console.WriteLine($"Student.GlobalVar = {Student.GlobalVar}");
        // 44. 物件初始化
        Student stu2 = new Student { Name = "Amy" };
        Console.WriteLine($"stu2.Name = {stu2.Name}");
        // 45. 陣列初始化
        int[] arr3 = new int[3] { 7, 8, 9 };
        Console.WriteLine($"arr3 = {{{string.Join(",", arr3)}}}");
        // 46. List 泛型集合
        var list = new System.Collections.Generic.List<int> { 1, 2, 3 };
        Console.WriteLine($"List<int> = {{{string.Join(",", list)}}}");
        // 47. Dictionary 泛型字典
        var dict = new System.Collections.Generic.Dictionary<string, int> { ["A"] = 1, ["B"] = 2 };
        Console.WriteLine($"Dictionary: A={dict["A"]}, B={dict["B"]}");
        // 48. foreach 迴圈
        foreach (var item in arr1) Console.WriteLine($"foreach arr1: {item}");
        // 49. for 迴圈
        for (int i2 = 0; i2 < arr1.Length; i2++) Console.WriteLine($"for arr1[{i2}] = {arr1[i2]}");
        // 50. while 迴圈
        int w = 0;
        while (w < 2) { Console.WriteLine($"while w = {w}"); w++; }
    }

    // 列舉型別
    enum Day { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }
    // 結構型別
    struct Point { public int X, Y; public Point(int x, int y) { X = x; Y = y; } }
    // 類別型別
    class Student
    {
        public string Name = "John"; // public 欄位
        private int Age = 20; // private 欄位
        public static int Count = 1; // static 靜態欄位
        public static int GlobalVar = 999; // 類別全域變數
        public int GetAge() => Age;
    }
}
