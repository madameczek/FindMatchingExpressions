# Find Matching Expressions

This code illustrates [my blog](https://blog.adameczek.pl/index.php/2023/04/01/znajdz-dzialania-czesc-ii/), where I show an application giving solutions in a math game.

## Math game

The rules are
1. There are given two sets of integers (each element > 0).
1. Between elements in each set a math is performed (+, -, *, /) respecting mathematical operators precedence.
1. So, two sets of expressions are formed.
1. Order of elements can not be changed.
1. Element can be joined to create new number.
1. Each intermediate operation gives integer result. Division operation gives no remaining.
1. Task is: Find pairs of expressions which give true equation.

### Examples

1. Set 1: 1, 2, 1
2. Set 2: 1, 2

Results:
1. 1 - 2 * 1 = 1 - 2 = -1
1. 1 - 2 / 1 = 1 - 2 = -1
1. 1 + 2 - 1 = 1 * 2 = 2
1. 1 * 2 * 1 = 1 * 2 = 2
1. 1 * 2 / 1 = 1 * 2 = 2
1. 1 + 2 * 1 = 1 + 2 = 3
1. 1 + 2 / 1 = 1 + 2 = 3
1. 1 * 2 + 1 = 1 + 2 = 3
1. 12 * 1 = 12 = 12
1. 12 / 1 = 12 = 12

## Application

The application on Github is following [my blog](https://blog.adameczek.pl/index.php/2023/04/01/znajdz-dzialania-czesc-ii/). I'm creating it in steps. So, it may not be running app, yet.  
But you can play with running application [here](https://playwithnumbers.azurewebsites.net/). Give Azure up to 4 minutes to recovery in case if app is detached.  
Currently the app has no validation and in case of wrong input you may need to reload.