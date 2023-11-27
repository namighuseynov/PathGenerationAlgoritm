import matplotlib.pyplot as plt
import numpy as np
from scipy.interpolate import CubicSpline

def Lagrange(x, X, Y):
    
    result = 0
    for i in range(len(Y)):
        p = 1
        for j in range(len(X)):
            if j != i:
                p = p * (x - X[j])/(X[i] - X[j]) 
        result = result + p*Y[i]
    return result;

#h = 0.5;
x = np.array([1, 2, 3, 4, 5])
y = np.array([2, 1, 4, 3, 5])
h = 0.05

plt.subplot(2, 1, 1);
plt.plot(x, y);


X_I = np.linspace(1, 5, 100);
Y_I = Lagrange(X_I, x, y)
print(X_I)


plt.subplot(2, 1, 2);
plt.plot(X_I, Y_I);


plt.show();
