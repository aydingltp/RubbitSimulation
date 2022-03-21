# Rubbit Simulation

![image](https://user-images.githubusercontent.com/30267270/159236402-e6282781-ecdc-4f40-ace0-35cba21b1d64.png)

For the purpose of this exercise, the following assumptions are made.
- Rabbits take one month to reach an age at which they may give birth.
- Every month thereafter, a breeding pair of rabbits produce one further pair of rabbits.
- Rabbits never die and never stop being able to produce further rabbits.

**How many pairs of rabbits will be produced from this single pair of rabbits after one year?**

## How did we solve the problem?

The rabbit population problem was conceived by Leonardo Fibonacci and presented in his book Liber Abaci.
We will use the fibonacci method to find the number of populations at the end of a given cycle.
However, different methods have been developed to solve this method.

E.g;
- Recursive metot
    -   Time Complexity: T(n) = T(n) which is linear. 
    -   Extra Space: O(n) if we consider the function call stack size, otherwise O(1).
- Dynamic Programming
    - Time Complexity:O(n) 
    - Extra Space: O(1)
- Space Optimized Method
    - Time Complexity:O(n) 
    - Extra Space: O(1)
- Another approach(Using formula) 
  - Time Complexity: O(logn), this is because calculating phi^n takes logn time
  - Space Complexity: O(1)

I preferred the recursive method. However, the formula can be used directly in terms of performance and output.

Also, I came across a source where the fibonacci method is used as a multi thread, I tried the same way, but it did not work in the same way :)

See : https://jacopretorius.net/2010/01/multithreading-example-in-c.html

**If you want to simulate for different animals, you must create a calculation method for the population of animals.**

## Output Rubbit Simulation

![image](https://user-images.githubusercontent.com/30267270/159235853-e043d8e7-1aae-4e99-b240-d94ff034f0d6.png)

## Sources
- https://medium.com/codingblackfemales/understanding-the-fibonacci-series-algorithm-rabbits-and-recurrence-eab9b4bdad5c
- https://proofwiki.org/wiki/Rabbit_Problem/Solution
- https://mathinsight.org/controlling_rabbit_population
- https://r-knott.surrey.ac.uk/Fibonacci/fibFormula.html
- https://www.geeksforgeeks.org/program-for-nth-fibonacci-number
- http://jwilson.coe.uga.edu/EMAT6680Fa11/Molnar/final3ram/final3ram.html
- https://www.mathscareers.org.uk/the-mathematics-of-rabbit-island
