import random
def sort(array_n):
    rigth=[]
    left=[]
    if len(array_n)<=1:
        return array_n
    midpoint=int(len(array_n)/2)
    for i in range(midpoint):
         left.append(array_n[i])
    s=midpoint
    while s<len(array_n):
         rigth.append(array_n[s])
         s=s+1
    left=sort(left)
    rigth=sort(rigth)
    result=merge(left,rigth)
    return result
def merge(left,rigth):
    result=[]
    while len(left)>0 and len(rigth)>0:
          if left[0]>rigth[0]:
              result.append(left[0])
              left.remove(left[0])
          else:
              result.append(rigth[0])
              rigth.remove(rigth[0])
    while len(left)>0:
          result.append(left[0])
          left.remove(left[0])
    while len(rigth)>0:
          result.append(rigth[0])
          rigth.remove(rigth[0])
    return result
def array_printer(array):
     for i in array:
          print('{0} '.format(i),end='')
array=[]
for i in range(20):
     array.append(random.randint(0,1000))
print ('not sorted array:', end='')
array_printer(array)
print ('\nsort with merge sort:',end='')
array=sort(array)
array_printer(array)
