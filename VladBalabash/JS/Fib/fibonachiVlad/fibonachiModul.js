var fibonachi=(function(){
    function fibonachiReqursionPrivate(n){
    if(n<=1){
        return n;
    }
    return fib(n-1)+fib(n-2);
}
    function fibonachiArrayPrivate(n){
        var arr=[n];
        arr[0]=0;
        arr[1]=1;
        for(var i=2;i<n;i++){
            arr[i]=arr[i-1]+arr[i-2];
        }
        return arr[n-1];
    }
    return {
        fibonachiReqursBase:fibonachiReqursionPrivate,
        fibonachiArrayBase:fibonachiArrayPrivate
    };
});

var object=new fibonachi();
console.log(object.fibonachiArrayBase(30));
console.log(object.fibonachiReqursBase(30));
