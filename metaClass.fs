//Inherit from the core function CLASS will make a class be a metaclass
class AMeta(fscript.CLASS){
    //the metaclass will call the __new__ method to create a class
    this.__new__=function(classname,baseclass,attrFunc){
        /*
            the __new__ funcion take tree arguments
            classname: the name of the class being created
            baseclass: the baseclass object of that class
            attrFunc: a function that declare all the attruibutes
         */
        //give a new function will replace the old one
        var attr=function(){
                this.hello = "world";
                attrFunc.apply(this);
            }
        console.log("AMeta creating class:"+classname)
        //don't forget to create a class normaly
        return new fscript.CLASS(classname,baseclass,attr);

        /*want to modify the existing one?
            var attr=function(){
                this.hello = "world";
                attrFunc();
            }
            then give this new one to the fscript.CLASS function
        */
    }
}

//Give the metaclass to class A, then class A will create by that metaclass
class A meta AMeta{
    this.a = 1;
}

var a = new A();

//The metaclass will be also extend to be, so now B will be created by the AMeta

class B extends A{}

var b = new B();

console.log(a.hello); //world
console.log(a.a); //world
console.log(b.hello); //world
console.dir(b)