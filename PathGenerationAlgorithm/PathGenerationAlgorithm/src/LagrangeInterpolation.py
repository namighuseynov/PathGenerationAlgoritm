class LagrangeInterpolation(object):
    def Interpolate(self, intp_x, X, Y):
        result = 0
        for i in range(len(Y)):
            p = 1
            for j in range(len(X)):
                if j != i:
                    p = p * (intp_x - X[j])/(X[i] - X[j])
            result = result + p*Y[i]
        return result