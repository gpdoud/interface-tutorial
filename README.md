# Interface-Tutorial

An interface is similar to a class with one main difference.

**Methods can be defined but not implemnted.**

```Java
public interface Print {
    public void Print(String str);
}
```

In C#, there is a convention that interface names start with a capital I. Java doesn't seem to have the same convention.

When a class implements one or more interfaces, the class must declare all the methods defined in the interfaces with the same signature (return type, name, parameter types). Failure to declare any of the methods in an interface will cause compiles to fail.

```Java
public class CheckingAccount implements Print {
    public void Print(String s) {
        // body of method omitted
    }
}
public class SavingsAccount implements Print {
    public void Print(String s) {
        // body of method omitted
    }
}
```

Another class that wants to use one or more of the classes the implement the interface can declare a variable/field/property of the typename of the interface.

The following code shows two classes (CheckingAccount & SavingsAccount) implementing the Print interface. Then, a collection of type Print[] is created and both instances are loaded into the collection. The interface is the common type that both instances share. When the instances are iterated within the `for()` look, only the methods defined in the interface may be called. Other methods that may be in the classes are unavailable.

```Java
Print chkAcct = new CheckingAccount();
Print savAcct = new SavingsAccount();
Print[] accounts = new Print[] { chkAcct, savAcct };
for(Print acct : accounts) {
    acct.Print();
}
```