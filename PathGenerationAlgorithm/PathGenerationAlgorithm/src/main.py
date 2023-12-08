import random
import LagrangeInterpolation
import wayPoints
import numpy as np
import matplotlib.pyplot as plt


LI = LagrangeInterpolation.LagrangeInterpolation()

X = wayPoints.generate_numbers(4, 200, 20)
print(X)
plt.scatter(X, X)

plt.show()