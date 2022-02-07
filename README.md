This is a simple application that checks whether a number is interesting or not, right now the application logic is all written in one place which works but is not ideal.

In future we are planning on adding some additional features:

- A prime check option - ./app prime 123
- A palindrome check option - ./app palindrome asdsa

These features don’t need to be implemented now but we want to focus on making the application more modular and more extendable so it’s easy to add CLI options in future, without refactoring too much existing code and without repeating to much logic.

Another thing we might want to change, is the definition of what makes a number interesting. The code should be broken up in a way that allows us to easy add new logic to this tool without having to intrusively refactor the code too much.

You will have 30 minutes to refactor the code and express your ideas on how we can support new CLI features easily in future. We are conscious 30 minutes is not a long time, and that you’ll likely not end up with a perfect solution, that’s why it’s important that you give us an active commentary and give us a window into what you’re thinking.
