# Why is this a bad solution?

This is a bad solution because ``Document.Publish`` method violates 2 principles of SOLID:

1. **Single Responsibility Principle (SRP)**: The ``Document.Publish`` method is responsible for both checking the state of the document and changing the state of the document. This is a violation of SRP because a method should have only one reason to change.
2. **Open/Closed Principle (OCP)**: The ``Document.Publish`` method is not closed for modification. If we want to add a new state to the document, we will have to modify the ``Document.Publish`` method. This is a violation of OCP because a class should be open for extension but closed for modification.