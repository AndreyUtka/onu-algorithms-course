import random
def inserting_sort(arr):
    for i in range(len(arr)):
         currElem = arr[i]
         prevKey = i - 1
         while prevKey >= 0 and arr[prevKey] > currElem :
             arr[prevKey+1] = arr[prevKey]
             arr[prevKey] = currElem
             prevKey=prevKey-1
             i=i-1
    return arr

s=[]
for i in range(20):
    s.append(random.randint(0,100))
print('Not sorted array:')
for i in range(len(s)):
    print('{0} '.format(s[i]),end='')
s=inserting_sort(s)
print('\nSorted array: ')
for i in range(len(s)):
    print('{0} '.format(s[i]),end='')
