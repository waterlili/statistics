import numpy as np
import matplotlib.pyplot as plt
from numpy.random import seed
from numpy.random import normal

np.random.normal(loc=0.0, scale=1.0, size=None)

#make this example reproducible
seed(1)

#generate sample of 200 values that follow a normal distribution 
data = normal(loc=0, scale=1, size=200)

#view first six values
data[0:200]


#find mean of sample
np.mean(data)

#find standard deviation of sample
np.std(data, ddof=1)

count, bins, ignored = plt.hist(data, 30)
plt.show()