var Fib = function ()
{
    function Fib2(n)
    {
        var i;
        var fib = [];
        fib[0] = 0;
        fib[1] = 1;
        for(i=2; i<=n; i++)
        {
            fib[i] = fib[i-2] + fib[i-1];
            //alert(fib[i]);
        }
        return fib[n];
    }

    function Fib1(n)
    {
        if(n<=1)
        return n;
        return Fib1(n-1)+Fib1(n-2);
    }

    return{
        FibonachiRecursion: Fib1,
        Fibonachi: Fib2
    }
};

var i=new Fib();
console.log(i.FibonachiRecursion(50));