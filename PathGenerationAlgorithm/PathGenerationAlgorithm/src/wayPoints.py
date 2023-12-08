import numpy as np
import random
import matplotlib.pyplot as plt

def generate_numbers(N, S, d):
    while(True):
        check = True
        positive_numbers = [random.randint(0, S) for i in range(N) ]

        V = np.array(positive_numbers)
        Sum = np.sum(V)
        numbers = [ item/Sum for item in positive_numbers ]
        numbers = np.dot(numbers, S)

        for i in range(np.size(numbers) - 1):
            if (numbers[i] - numbers[i + 1]) < d:
                check = False
        if check:
            return np.sort(numbers)
        


def GeneratePoint(count):
    X = random.randint(1, 10)
    plt.scatter(X);


    plt.show()
    pass
