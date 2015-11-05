var fib2=function(n){
    var arr=[n];
    arr[0]=0;
    arr[1]=1;
    for(var i=2;i<n;i++){
        arr[i]=arr[i-1]+arr[i-2];
    }
    return arr[n-1];
}
var fib=function(n){
    if(n<=1){
        return n;
    }
    
    var t="";
    return fib(n-1)+fib(n-2);
}
