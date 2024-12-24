# Single responsibility principle

The single resposibility principle states that a class should have only one reason to change. This means that a class should have only one job or responsibility. If a class has more than one responsibility, it should be refactored into multiple classes, each with a single responsibility.

In this example we created the ``UserService`` class that is responsible for authenticating users.

The ``EmailService`` class which is responsible for sending emails.

The ``User`` class which is resposible for holding user data.

Then we used depedency injection and composition to compose these classes together.