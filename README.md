# ПРОЕКТ - 1234321
**Данный проект создан при попытке изучения техники тестовой проверки библитек, классов и методов.**
**Создан проект на основе языка программирования C#.**
## СОСТАВНЫЕ

### StClass
    StClass -класс созданный для проверки работы библиотеки, включает в себя всего лишь одну 
    строчку кода ---> **return "A_" + str;**
### UnitTest1
    UnitTest1 - TestClass созданные непосредственно для проверки внутренних данных
        string s = "CMD";
        string a = "A_" + s;
        Assert.AreEqual(a, StClass.AddA(s));
