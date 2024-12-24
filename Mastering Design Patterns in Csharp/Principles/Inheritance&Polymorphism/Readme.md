# Inheritance & Polymorphism

Inheritance focuses on reducing code repetition by allowing 
child / derived classes to inherit properties and methods from the parent class.

Polymorphism is the idea of overriding some of the methods so that the same method
behaves differently depending on the object it's called on.

One real-world example I've experienced **inheritance** and **polymorphism** 
was when building a product available as a SaaS and SH, here we would create 
a base class that holds all the product logic, and then the child classes that 
would represent the SaaS and SH versions would implement their own specific logic
if needed.