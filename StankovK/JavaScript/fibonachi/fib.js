/**
 * Created by Konstantin on 23.10.2014.
 */
//function fib2(n){
//    var a= Array();
//    a[0]=0;
//    a[1]=1;
//    for(var i=2;i<=n;i++)
//    {
//        a[i]=a[i-1]+a[i-2];
//    }
//    return a[n];
//}
//function fib(n)
//{
//    if(n<=1)
//    return n;
//    return fib(n-1)+fib(n-2);
//}

var Fibonacci=(function(){
    function _fibRecursion(n){
        if(n<=1)
            return n;
        return _fibRecursion(n-1)+_fibRecursion(n-2);
    }
    function _fibMass(n){
        var a= Array();
        a[0]=0;
        a[1]=1;
        for(var i=2;i<=n;i++)
        {
            a[i]=a[i-1]+a[i-2];
        }
        return a[n];
    }
    return {
        fibRecursion: _fibRecursion,
        fibMass: _fibMass
    }
})();
console.log(Fibonacci.fibMass(10));
console.log(Fibonacci.fibRecursion(10));
