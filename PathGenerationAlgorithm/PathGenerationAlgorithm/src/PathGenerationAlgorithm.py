import matplotlib.pyplot as plt
import numpy as np
from LagrangeInterpolation import LagrangeInterpolation

x = np.array([1, 2, 3, 4, 5])
y = np.array([2, 1, 4, 3, 5])
h = 0.05

plt.subplot(2, 1, 1);
plt.plot(x, y);

A = LagrangeInterpolation()

X_I = np.linspace(1, 5, 100);
Y_I = A.Interpolate(X_I, x, y); 


plt.subplot(2, 1, 2);
plt.plot(X_I, Y_I);


plt.show();
