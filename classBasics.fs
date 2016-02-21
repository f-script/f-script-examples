class A{
    //public
    this.a =1;
    this.b =2;
    //pravite
    var c = 3;
    //constructor
    this.A = function(a,b){
        this.a = a;
        this.b = b;
        A.c = 4;
    };
}

//extends a class
class B extends A{
    this.d = 1;
}
// can be short of
/*
    class B(A){

    }
 */

class C extends B{
    this.e = 111;
}

var a = new A(10,20);
console.log(a);
var b = new B();
console.log(b);
var c = new C();
console.log(c);

//public class A
export A;

// not export B, so