def current_time():
     from datetime import datetime
     dt = datetime.now()
     return dt.microsecond
def fib(a):
     if a<=1:
        return a
     return fib(a-1)+fib(a-2)
def fib_m2(n):
     a,b=0,1
     s_time=current_time()
     for i in range(n):
           a,b=b,a+b
     print ('{0} during {1} microseconds'.format(a,current_time()-s_time))
print(current_time())
fib_m2(100)
s_time=current_time()
print ('{0} during {1} micriseconds'.format(fib(100),current_time()-s_time))     
#for i in range(40):
#    t_start=time.time()
#    f=fib(i)
#    t_end=time.time()
#    print '{0}: {1} during {2:4f}'.format(i,f,t_end-t_start)
