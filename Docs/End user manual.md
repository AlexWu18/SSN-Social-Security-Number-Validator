# End User Manual

### Introduction
The final user manual of the SSN (Social Security Number) Validator program is attached to this work.
<br>

![image](https://user-images.githubusercontent.com/65258331/169097246-f5653986-8620-49a7-9dd3-c2cd11a51c48.png)

From which the documentation of the same will be shown below, of which ***regular expression*** was used to be able to complete the required conditions.

```C#
        // can't be 666 or 000, second part need to be (01-99) and not three number, the last part different to 0000 (only four number)
        string PatternSSN = "^(?!666|000|9\\d{2})\\d{3}-(?!00)\\d{2}-(?!0{4})\\d{4}$"; 
        Regex regex = new Regex(PatternSSN);// create a Regular expression that have the three conditions
```
In addition, examples were created that validate the correct use of regular expressions, not only that, but also that show a consistent result of it.

``` C#
        bool Example1 = regex.IsMatch("736-21-5481"); //that example are "true" because comply the three conditions.
        bool Example2 = regex.IsMatch("666-25-0254"); // In that case is "False" because start with 666
        bool Example3 = regex.IsMatch("156-212-5561");// is "False" because the second part before the hyphen have three number intead of two 
        bool Example4 = regex.IsMatch("695-55-0000"); // Is "False because" the third part end with 0000
        bool Example5 = regex.IsMatch("001-21-9514");
```

<br>
<br>

#### ***Below are the steps to run the program***

##### 1. In the part of the red lines it represents the algorithm of the code, besides that is where the changes and validation of the aforementioned conditions are made. therefore any change must take into account the conditions.

![image](https://user-images.githubusercontent.com/65258331/169099700-3b2bd861-e0ae-4144-8f2e-8d2ad2b940ad.png)

##### 2. This is the source code as such.
![image](https://user-images.githubusercontent.com/65258331/169100565-1d5e5ca8-4840-440b-9a12-9c1f459a75be.png)

##### 3. Press the button where the red lines are, this will make the program run with the code present.
![image](https://user-images.githubusercontent.com/65258331/169100834-5c437a86-fdfd-4673-b8f5-45feb5602092.png)

##### 4. Finally, having pressed the button should show a console tab that will be shown below.
![image](https://user-images.githubusercontent.com/65258331/169101505-f6d82c67-1229-473c-9ffa-b6c73c2a19dd.png)

