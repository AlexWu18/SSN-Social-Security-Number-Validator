## Installation method and use in format

#### 1. First you must download any code editor that allows you in this case to handle the C# programming language. An example of this can be Visual studio Code or Visual Studio IDE.
<img src = "https://user-images.githubusercontent.com/65258331/169088083-7b9cc2d0-fcc1-4405-8887-acbece2e41eb.png" width = "100" height = "100" alt = "Visual Studio IDE LOGO" align = "left" />
<img src = "https://user-images.githubusercontent.com/65258331/169088248-d0149273-2747-4a21-939d-c1c1bdce4c59.png" width = "100" height = "100" alt = "Visual Studio IDE LOGO" align = "center" />


#### 2. Already having the code editor, copy the source code (the same from the repository) of the program and make sure you have it similar.
In order for this to be executed correctly, we must see what the conditions of the present exercise or practice are.
The valid SSN (Social Security Number) must satisfy the following conditions:
* It should have 9 digits.
* It should be divided into 3 parts by hyphen (-).
  * The first part should have 3 digits and should not be 000, 666, or between 900 and 999.
  * The second part should have 2 digits and it should be from 01 to 99.
  * The third part should have 4 digits and it should be from 0001 to 9999.

*This Regular Expression meets the expected requirements.*

``` C#
 string PatternSSN = "^(?!666|000|9\\d{2})\\d{3}-(?!00)\\d{2}-(?!0{4})\\d{4}$"; 
        Regex regex = new Regex(PatternSSN);
```

#### 3. Only what is in parentheses should be replaced, as long as it meets the aforementioned conditions.

``` C#
bool Example1 = regex.IsMatch("736-21-5481"); //that example are "true" because comply the three conditions.
        bool Example2 = regex.IsMatch("666-25-0254"); // In that case is "False" because start with 666
        bool Example3 = regex.IsMatch("156-212-5561");// is "False" because the second part before the hyphen have three number intead of two 
        bool Example4 = regex.IsMatch("695-55-0000"); // Is "False because" the third part end with 0000
        bool Example5 = regex.IsMatch("001-21-9514");
```

#### 4. Finally you run the program and it should show results of "True or False"
